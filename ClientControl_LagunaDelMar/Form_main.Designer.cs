namespace ClientControl_LagunaDelMar
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnRequest = new System.Windows.Forms.Button();
            this.lblGPM = new System.Windows.Forms.Label();
            this.tbGPMM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.tbGPM = new System.Windows.Forms.NumericUpDown();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.tpGPM = new System.Windows.Forms.ToolTip(this.components);
            this.tpGPMM = new System.Windows.Forms.ToolTip(this.components);
            this.tbGPMObjActual = new System.Windows.Forms.TextBox();
            this.tpServerIP = new System.Windows.Forms.ToolTip(this.components);
            this.gBoxConexion = new System.Windows.Forms.GroupBox();
            this.gBoxControl = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tbGPM)).BeginInit();
            this.gBoxConexion.SuspendLayout();
            this.gBoxControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Enabled = false;
            this.btnRequest.Location = new System.Drawing.Point(6, 138);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(90, 23);
            this.btnRequest.TabIndex = 0;
            this.btnRequest.Text = "Enviar";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // lblGPM
            // 
            this.lblGPM.AutoSize = true;
            this.lblGPM.Location = new System.Drawing.Point(6, 16);
            this.lblGPM.Name = "lblGPM";
            this.lblGPM.Size = new System.Drawing.Size(134, 13);
            this.lblGPM.TabIndex = 3;
            this.lblGPM.Text = "Gotas Por Minuto Objetivo:";
            // 
            // tbGPMM
            // 
            this.tbGPMM.Location = new System.Drawing.Point(6, 71);
            this.tbGPMM.Name = "tbGPMM";
            this.tbGPMM.ReadOnly = true;
            this.tbGPMM.Size = new System.Drawing.Size(266, 20);
            this.tbGPMM.TabIndex = 6;
            this.tpGPMM.SetToolTip(this.tbGPMM, "Medición de gotas por minuto actuales.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gotas por min. medidas: ";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(6, 55);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(90, 23);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // tbGPM
            // 
            this.tbGPM.Location = new System.Drawing.Point(6, 32);
            this.tbGPM.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.tbGPM.Name = "tbGPM";
            this.tbGPM.Size = new System.Drawing.Size(266, 20);
            this.tbGPM.TabIndex = 7;
            this.tpGPM.SetToolTip(this.tbGPM, "Control de gotas por minuto (GPM)");
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnStatus.Location = new System.Drawing.Point(102, 65);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(78, 13);
            this.lblConnStatus.TabIndex = 8;
            this.lblConnStatus.Text = "No conectado.";
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(6, 16);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(54, 13);
            this.lblServerIP.TabIndex = 9;
            this.lblServerIP.Text = "Server IP:";
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(6, 32);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(266, 20);
            this.tbServerIP.TabIndex = 10;
            this.tpServerIP.SetToolTip(this.tbServerIP, "Direccion IP del controlador y montor de valvula.");
            // 
            // tpGPM
            // 
            this.tpGPM.ToolTipTitle = "GPM";
            // 
            // tpGPMM
            // 
            this.tpGPMM.ToolTipTitle = "GPMM";
            // 
            // tbGPMObjActual
            // 
            this.tbGPMObjActual.Location = new System.Drawing.Point(6, 112);
            this.tbGPMObjActual.Name = "tbGPMObjActual";
            this.tbGPMObjActual.ReadOnly = true;
            this.tbGPMObjActual.Size = new System.Drawing.Size(266, 20);
            this.tbGPMObjActual.TabIndex = 9;
            this.tpGPMM.SetToolTip(this.tbGPMObjActual, "Medición de gotas por minuto actuales.");
            // 
            // gBoxConexion
            // 
            this.gBoxConexion.Controls.Add(this.lblServerIP);
            this.gBoxConexion.Controls.Add(this.tbServerIP);
            this.gBoxConexion.Controls.Add(this.btnConectar);
            this.gBoxConexion.Controls.Add(this.lblConnStatus);
            this.gBoxConexion.Location = new System.Drawing.Point(12, 27);
            this.gBoxConexion.Name = "gBoxConexion";
            this.gBoxConexion.Size = new System.Drawing.Size(283, 97);
            this.gBoxConexion.TabIndex = 11;
            this.gBoxConexion.TabStop = false;
            this.gBoxConexion.Text = "Conexión";
            // 
            // gBoxControl
            // 
            this.gBoxControl.Controls.Add(this.label2);
            this.gBoxControl.Controls.Add(this.tbGPMObjActual);
            this.gBoxControl.Controls.Add(this.lblGPM);
            this.gBoxControl.Controls.Add(this.btnRequest);
            this.gBoxControl.Controls.Add(this.tbGPM);
            this.gBoxControl.Controls.Add(this.label1);
            this.gBoxControl.Controls.Add(this.tbGPMM);
            this.gBoxControl.Enabled = false;
            this.gBoxControl.Location = new System.Drawing.Point(12, 130);
            this.gBoxControl.Name = "gBoxControl";
            this.gBoxControl.Size = new System.Drawing.Size(283, 165);
            this.gBoxControl.TabIndex = 12;
            this.gBoxControl.TabStop = false;
            this.gBoxControl.Text = "Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gotas por min. Obj Actual: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.settingsToolStripMenuItem.Text = "Opciones";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnRequest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 321);
            this.Controls.Add(this.gBoxControl);
            this.Controls.Add(this.gBoxConexion);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(323, 360);
            this.MinimumSize = new System.Drawing.Size(323, 360);
            this.Name = "frmMain";
            this.Text = "Control de Valvula de Aceite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbGPM)).EndInit();
            this.gBoxConexion.ResumeLayout(false);
            this.gBoxConexion.PerformLayout();
            this.gBoxControl.ResumeLayout(false);
            this.gBoxControl.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label lblGPM;
        private System.Windows.Forms.TextBox tbGPMM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.NumericUpDown tbGPM;
        private System.Windows.Forms.Label lblConnStatus;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.ToolTip tpGPMM;
        private System.Windows.Forms.ToolTip tpGPM;
        private System.Windows.Forms.ToolTip tpServerIP;
        private System.Windows.Forms.GroupBox gBoxConexion;
        private System.Windows.Forms.GroupBox gBoxControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGPMObjActual;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

