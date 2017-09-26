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
            this.tbGrados = new System.Windows.Forms.NumericUpDown();
            this.tpGPMM = new System.Windows.Forms.ToolTip(this.components);
            this.tbGPMObjActual = new System.Windows.Forms.TextBox();
            this.tpServerIP = new System.Windows.Forms.ToolTip(this.components);
            this.gBoxConexion = new System.Windows.Forms.GroupBox();
            this.gBoxControlAutomatico = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxControlManual = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAutomatico = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.gBoxLog = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tbGPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGrados)).BeginInit();
            this.gBoxConexion.SuspendLayout();
            this.gBoxControlAutomatico.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gBoxControlManual.SuspendLayout();
            this.gBoxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Enabled = false;
            this.btnRequest.Location = new System.Drawing.Point(12, 392);
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
            this.tbGPMM.Location = new System.Drawing.Point(12, 143);
            this.tbGPMM.Name = "tbGPMM";
            this.tbGPMM.ReadOnly = true;
            this.tbGPMM.Size = new System.Drawing.Size(266, 20);
            this.tbGPMM.TabIndex = 6;
            this.tpGPMM.SetToolTip(this.tbGPMM, "Medición de gotas por minuto actuales.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 127);
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
            // tbGrados
            // 
            this.tbGrados.Location = new System.Drawing.Point(6, 32);
            this.tbGrados.Maximum = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.tbGrados.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbGrados.Name = "tbGrados";
            this.tbGrados.Size = new System.Drawing.Size(266, 20);
            this.tbGrados.TabIndex = 9;
            this.tpGPM.SetToolTip(this.tbGrados, "Control de gotas por minuto (GPM)");
            this.tbGrados.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tpGPMM
            // 
            this.tpGPMM.ToolTipTitle = "GPMM";
            // 
            // tbGPMObjActual
            // 
            this.tbGPMObjActual.Location = new System.Drawing.Point(6, 71);
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
            // gBoxControlAutomatico
            // 
            this.gBoxControlAutomatico.Controls.Add(this.label2);
            this.gBoxControlAutomatico.Controls.Add(this.tbGPMObjActual);
            this.gBoxControlAutomatico.Controls.Add(this.lblGPM);
            this.gBoxControlAutomatico.Controls.Add(this.tbGPM);
            this.gBoxControlAutomatico.Enabled = false;
            this.gBoxControlAutomatico.Location = new System.Drawing.Point(12, 192);
            this.gBoxControlAutomatico.Name = "gBoxControlAutomatico";
            this.gBoxControlAutomatico.Size = new System.Drawing.Size(283, 101);
            this.gBoxControlAutomatico.TabIndex = 12;
            this.gBoxControlAutomatico.TabStop = false;
            this.gBoxControlAutomatico.Text = "Control Automatico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gotas por min. Obj Actual: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
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
            // gBoxControlManual
            // 
            this.gBoxControlManual.Controls.Add(this.label3);
            this.gBoxControlManual.Controls.Add(this.tbGrados);
            this.gBoxControlManual.Location = new System.Drawing.Point(12, 322);
            this.gBoxControlManual.Name = "gBoxControlManual";
            this.gBoxControlManual.Size = new System.Drawing.Size(283, 64);
            this.gBoxControlManual.TabIndex = 14;
            this.gBoxControlManual.TabStop = false;
            this.gBoxControlManual.Text = "Control Manual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grados de Giro:";
            // 
            // rbAutomatico
            // 
            this.rbAutomatico.AutoSize = true;
            this.rbAutomatico.Location = new System.Drawing.Point(12, 169);
            this.rbAutomatico.Name = "rbAutomatico";
            this.rbAutomatico.Size = new System.Drawing.Size(78, 17);
            this.rbAutomatico.TabIndex = 15;
            this.rbAutomatico.TabStop = true;
            this.rbAutomatico.Text = "Automatico";
            this.rbAutomatico.UseVisualStyleBackColor = true;
            this.rbAutomatico.CheckedChanged += new System.EventHandler(this.rbAutomatico_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(12, 299);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 16;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // gBoxLog
            // 
            this.gBoxLog.Controls.Add(this.rtbLog);
            this.gBoxLog.Location = new System.Drawing.Point(301, 27);
            this.gBoxLog.Name = "gBoxLog";
            this.gBoxLog.Size = new System.Drawing.Size(311, 387);
            this.gBoxLog.TabIndex = 17;
            this.gBoxLog.TabStop = false;
            this.gBoxLog.Text = "Log";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(6, 16);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(299, 372);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearLogToolStripMenuItem.Text = "Clear Log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnRequest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 426);
            this.Controls.Add(this.gBoxLog);
            this.Controls.Add(this.rbManual);
            this.Controls.Add(this.rbAutomatico);
            this.Controls.Add(this.gBoxControlManual);
            this.Controls.Add(this.gBoxControlAutomatico);
            this.Controls.Add(this.gBoxConexion);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbGPMM);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(640, 465);
            this.MinimumSize = new System.Drawing.Size(640, 465);
            this.Name = "frmMain";
            this.Text = "Control de Valvula de Aceite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbGPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGrados)).EndInit();
            this.gBoxConexion.ResumeLayout(false);
            this.gBoxConexion.PerformLayout();
            this.gBoxControlAutomatico.ResumeLayout(false);
            this.gBoxControlAutomatico.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBoxControlManual.ResumeLayout(false);
            this.gBoxControlManual.PerformLayout();
            this.gBoxLog.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gBoxControlAutomatico;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGPMObjActual;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBoxControlManual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tbGrados;
        private System.Windows.Forms.RadioButton rbAutomatico;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.GroupBox gBoxLog;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
    }
}

