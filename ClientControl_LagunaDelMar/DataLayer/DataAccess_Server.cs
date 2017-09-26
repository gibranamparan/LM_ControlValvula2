using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ClientControl_LagunaDelMar.DataLayer
{
    class DataAccess_Server
    {
        public string serverIP { get; set; }

        public DataAccess_Server(string serverIP)
        {
            this.serverIP = serverIP;
        }

        /// <summary>
        /// Llamada al servidor solo para obtener informacion
        /// </summary>
        /// <returns></returns>
        public ValveParameters tomarDatosActuales()
        {
            String urlParams = "reportar?";
            return getValveData(urlParams);
        }

        /// <summary>
        /// Se envian las gotas por minuto al servidor en forma de parametros GET
        /// recibiendo JSON con gotas medidas.
        /// </summary>
        /// <param name="GPM"></param>
        /// <returns></returns>
        public ValveParameters moverValvula(decimal GPM,decimal grados,bool automatico)
        {
            String urlParams = String.Format("mover?GPM={0}&servoDegrees={1}&autoControl={2}", GPM, grados, automatico?1:0);
            //String urlParams = "mover?GPM=" + GPM + "&automatico=";
            return getValveData(urlParams);
        }

        /// <summary>
        /// Metodo generico para comunicarse con el servidor, recibiendo parametros get
        /// para enviarlos al server y recibir respuesta.
        /// </summary>
        /// <param name="urlParams">Cadena de caracteres con el query string para enviarse al server.</param>
        /// <returns>Respuesta del servidor en forma de objeto.</returns>
        private ValveParameters getValveData(String urlParams)
        {
            ValveParameters valveData = new ValveParameters();
            String serverIP = "http://" + this.serverIP + "/";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(serverIP + urlParams);
                request.Timeout = 3000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string tempString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                valveData = JsonConvert.DeserializeObject<ValveParameters>(tempString);
                valveData.success = true;
            }
            catch (WebException exc)
            {
                valveData.success = false;
                valveData.errorMsg = exc.Message;
            }
            return valveData;
        }

        /// <summary>
        /// Objeto que contiene toda la informacion que se recibe del servidor en cada transaccion.
        /// </summary>
        public class ValveParameters
        {
            public String GPM { get; set; }
            public String servoDegrees { get; set; }
            public String GPMM { get; set; }
            public bool success { get; set; }
            public bool autoControl { get; set; }
            public String errorMsg { get; set; }
            
            public ValveParameters()
            {
                this.GPM = "0";
                this.servoDegrees = "0";
                this.GPMM = "0";
            }

            public override string ToString()
            {
                return String.Format($"GPM = {this.GPM}, ServoDegrees = {this.servoDegrees}, GPMM = {this.GPMM}");
            }
        }
    }
}
