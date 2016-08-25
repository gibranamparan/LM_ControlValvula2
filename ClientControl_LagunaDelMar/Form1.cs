using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ClientControl_LagunaDelMar
{
    public partial class frmMain : Form
    {
        //String serverIP = @"http://169.254.204.40/";
        String serverIP = @"http://192.168.1.111/";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            enviarYActualizar();
        }

        private void tbGPM_ValueChanged(object sender, EventArgs e)
        {
            enviarYActualizar();
        }

        private void enviarYActualizar()
        {
            String gpm = tbGPM.Text;
            ValveParameters valveData = moverValvula(gpm);
            tbGrados.Text = valveData.servoDegrees;
            tbGPMM.Text = valveData.GPM;
        }

        private void actualizarDatos()
        {
            ValveParameters valveData = tomarDatosActuales();
            tbGrados.Text = valveData.servoDegrees;
            tbGPM.Value = int.Parse(valveData.servoDegrees);
            tbGPMM.Text = valveData.GPM;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        //Se reportan datos sin enviar nuevos
        public ValveParameters tomarDatosActuales()
        {
            String urlParams = "reportar?";
            return getValveData(urlParams);
        }

        //Se envia al servidor el GPM deseado
        public ValveParameters moverValvula(String GPM)
        {
            String urlParams = "mover?GPM=" + GPM;
            return getValveData(urlParams);
        }

        private ValveParameters getValveData(String urlParams)
        {
            ValveParameters valveData = new ValveParameters();
            try { 
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(serverIP + urlParams);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string tempString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                valveData = JsonConvert.DeserializeObject<ValveParameters>(tempString);
            }catch(WebException exc){
                MessageBox.Show("Error al conectarse con el servidor. Detalles: " + exc.InnerException, "Error de Conexión", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return valveData;
        }


    }
    public class ValveParameters
    {
        public String GPM { get; set; }
        public String servoDegrees { get; set; }
        public ValveParameters()
        {
            this.GPM = "0";
            this.servoDegrees = "0";
        }
    }

}
