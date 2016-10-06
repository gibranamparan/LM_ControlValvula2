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
using System.Threading;
using Newtonsoft.Json;

namespace ClientControl_LagunaDelMar
{
    public partial class frmMain : Form
    {
        //String serverIP = @"http://169.254.204.40/";
        //String serverIP = @"http://192.168.1.205/";
        Boolean conectado = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            enviarYActualizar();
        }

        private void enviarYActualizar()
        {
            String gpm = tbGPM.Text;
            ValveParameters valveData = moverValvula(gpm);
            tbGPMM.Text = valveData.GPMM;
        }

        private void actualizarDatos()
        {
            ValveParameters valveData = tomarDatosActuales();
            //tbGPM.Value = int.Parse(valveData.GPM);
            tbGPMM.Text = valveData.GPMM;
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
            String serverIP = "http://" + tbServerIP.Text+"/";
            try { 
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(serverIP + urlParams);
                request.Timeout = 1000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string tempString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                valveData = JsonConvert.DeserializeObject<ValveParameters>(tempString);

                setConnectionStatus(conectado);
            }catch(WebException exc){

                MessageBox.Show("Error al conectarse con el servidor. Detalles: " + exc.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setConnectionStatus(false);
            }
            return valveData;
        }

        public void setConnectionStatus(bool connected)
        {
            if (connected)
            {
                lblConnStatus.Text = "Conectado.";
                lblConnStatus.ForeColor = Color.Green;
                btnConectar.Text = "Desconectar";
            }
            else
            {
                lblConnStatus.Text = "No conectado.";
                lblConnStatus.ForeColor = Color.Red;
                btnConectar.Text = "Conectar";
            }
            conectado = connected;
            tbServerIP.ReadOnly = conectado;
            btnRequest.Enabled = conectado;

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conectado = !conectado;
            if (conectado) { 
                iniciarConexion();
                Thread.Sleep(1000);
                int val = 0;
                int.TryParse(tbGPMM.Text, out val);
                tbGPM.Value = val;
            }
            else
            {
                setConnectionStatus(false);
            }
        }

        private void iniciarConexion()
        {
            Thread listener = new Thread(() =>
            {
                while (conectado)
                {
                    this.BeginInvoke(new MethodInvoker(delegate
                    {
                        actualizarDatos();
                    }));
                    Thread.Sleep(800);
                }
            });
            listener.IsBackground = true;
            listener.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            conectado = false;
        }


    }
    public class ValveParameters
    {
        public String GPM { get; set; }
        public String servoDegrees { get; set; }
        public String GPMM { get; set; }
        public ValveParameters()
        {
            this.GPM = "0";
            this.servoDegrees = "0";
            this.GPMM = "0";
        }
    }

}
