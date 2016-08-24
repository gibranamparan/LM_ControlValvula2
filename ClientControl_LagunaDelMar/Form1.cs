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
        String serverIP = @"http://169.254.204.40/";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            String gpm = tbGPM.Text;
            ValveParameters valveData = moverValvula(gpm);
            tbGrados.Text = valveData.servoDegrees;
            tbGPMM.Text = valveData.GPM;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ValveParameters valveData = tomarDatosActuales();
            tbGrados.Text = valveData.servoDegrees;
            tbGPMM.Text = valveData.GPM;
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
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(serverIP + urlParams);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string tempString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            ValveParameters valveData = JsonConvert.DeserializeObject<ValveParameters>(tempString);

            return valveData;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }


    }
    public class ValveParameters
    {
        public String GPM { get; set; }
        public String servoDegrees { get; set; }
    }

}
