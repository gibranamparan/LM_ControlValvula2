using ClientControl_LagunaDelMar.DataLayer.DSSettingsTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SETTING_NAMES = ClientControl_LagunaDelMar.DataLayer.DataAccess_Settings.SETTING_NAMES;

namespace ClientControl_LagunaDelMar
{
    public partial class Form_settings : Form
    {
        public frmMain frmMain { get; set; }
        SettingsTableAdapter taSettings = new SettingsTableAdapter();

        public Form_settings()
        {
            InitializeComponent();
        }

        public Form_settings(frmMain main)
        {
            InitializeComponent();
            this.frmMain = main;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int numReg = 0;
            numReg = taSettings.UpdateQueryBySettingName(tbServerIP.Text, SETTING_NAMES.SERVER_URL);
            if(numReg>0)
            {
                MessageBox.Show("Opciones guardadas satisfactoriamente", "Opciones", MessageBoxButtons.OK,MessageBoxIcon.Information);
                frmMain.setNewServerURL(tbServerIP.Text);
                this.Close();
            }else
                MessageBox.Show("No fue posible modificar las opciones. Intentelo de nuevo o consulte al administrador.", 
                    "Opciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void form_settings_Load(object sender, EventArgs e)
        {
            tbServerIP.Text = taSettings.getSettingByName(SETTING_NAMES.SERVER_URL);
        }
    }
}
