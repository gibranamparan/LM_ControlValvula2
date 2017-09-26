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
using ClientControl_LagunaDelMar.DataLayer;
using static ClientControl_LagunaDelMar.DataLayer.DataAccess_Server;
using ClientControl_LagunaDelMar.DataLayer.DSSettingsTableAdapters;
using SETTING_NAMES = ClientControl_LagunaDelMar.DataLayer.DataAccess_Settings.SETTING_NAMES;
using ClientControl_LagunaDelMar.VModel;

namespace ClientControl_LagunaDelMar
{
    public partial class frmMain : Form
    {
        //String serverIP = @"http://169.254.204.40/";
        private bool conectado = false;
        DataAccess_Server daServer;
        SettingsTableAdapter taSettings = new SettingsTableAdapter();
        VMLog log = new VMLog();

        private void frmMain_Load(object sender, EventArgs e){ }

        public frmMain()
        {
            InitializeComponent();
            //Se muestra en pantalla el ip por defeccto guardado en base de datos
            tbServerIP.Text = taSettings.getSettingByName(SETTING_NAMES.SERVER_URL);
            //tbServerIP.Text = "192.168.1.121";
            daServer = new DataAccess_Server(tbServerIP.Text);

            setAutomaticControl(true);
            printInLog("***Bienvenido***");
        }

        private void printInLog(string newMessage)
        {
            log.agregarNuevoMensaje(newMessage);
            rtbLog.Text = log.ToString();
        }

        private void setAutomaticControl(bool isAuto)
        {
            rbAutomatico.Checked = isAuto;
            rbManual.Checked = !isAuto;
            gBoxControlAutomatico.Enabled = isAuto && this.conectado;
            gBoxControlManual.Enabled = !isAuto && this.conectado;
        }

        /// <summary>
        /// Introduce en pantalla una nueva IP y desconecta la aplicacion del servidor.
        /// </summary>
        /// <param name="ip"></param>
        public void setNewServerURL(string ip)
        {
            this.setConnectionStatus(false);
            tbServerIP.Text = ip;
        }

        /// <summary>
        /// Segun el estado de la conexion, cambia el estado de la pantalla para representar
        /// si la aplicacion se encuentra o no conectada al servidor.
        /// </summary>
        /// <param name="estado"></param>
        public void setConnectionStatus(bool estado)
        {
            if (estado)
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
            conectado = estado;
            tbServerIP.ReadOnly = conectado;
            btnRequest.Enabled = conectado;

            if (!conectado)
                printInLog("Error al intentar conexión.");

            setAutomaticControl(rbAutomatico.Checked);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conectado = !conectado;
            if (conectado) { 
                iniciarConexion();
            }
            else
                setConnectionStatus(false);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            daServer.moverValvula(tbGPM.Value, tbGrados.Value, rbAutomatico.Checked);
        }

        /// <summary>
        /// Inicializa un hilo dentro del cual se realiza constantemente llamdas al servidor
        /// para obtener en tiempo real el goteo y el 
        /// </summary>
        private void iniciarConexion()
        {
            daServer.serverIP = tbServerIP.Text;
            Thread listener = new Thread(() =>
            {
                ValveParameters data = new ValveParameters();
                //Previene que otro hilo ejecute el codigo delegado al hilo padre mientras este haciendose una solicitud
                bool requestFlag = false; 
                do
                {
                    if (!requestFlag)
                    {
                        this.BeginInvoke(new MethodInvoker(delegate
                        {
                            //Se levanta la bandera para evitar accesos de otros hilos
                            requestFlag = true;

                            data = daServer.tomarDatosActuales(); //Se solicitan datos del servidor

                            //Si se desconecto el servidor, se muestra un mensaje de error
                            if (data.success) 
                                showValues(data); //Si hubo respuesta del servidor, se muestra en pantalla

                            //Se marca el servidor como desconectado
                            setConnectionStatus(data.success);

                            //Si ocurrio un error al hacer la conexion, se muestra en pantalla
                            if (!data.success)
                                MessageBox.Show("Error al conectarse con el servidor. Detalles: " + data.errorMsg,
                                    "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //Al terminar la solicitud, se desbloquea el codigo delegado
                            requestFlag = false;
                        }));
                    }
                    Thread.Sleep(800);
                } while (conectado) ;
            });
            listener.IsBackground = true;
            listener.Start();
        }

        private void showValues(ValveParameters data)
        {
            tbGPMObjActual.Text = decimal.Parse(data.GPM).ToString();
            tbGPMM.Text = data.GPMM;
            printInLog(data.ToString());
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Al cerrar la aplicacion, se marca la conexion como desconectada.
            conectado = false;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se abre ventana de opciones
            Form frmSettings = new Form_settings(this);
            frmSettings.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAbout = new Form_About();
            frmAbout.ShowDialog();
        }

        private void rbAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            setAutomaticControl(((RadioButton)sender).Checked);
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            setAutomaticControl(!((RadioButton)sender).Checked);
        }

        private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rtbLog.Text = string.Empty;
            log.clearLog();
            printInLog("Log cleared.");
        }
    }

}
