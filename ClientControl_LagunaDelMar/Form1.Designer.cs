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
            this.tpServerIP = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbGPM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Enabled = false;
            this.btnRequest.Location = new System.Drawing.Point(12, 90);
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
            this.lblGPM.Location = new System.Drawing.Point(9, 9);
            this.lblGPM.Name = "lblGPM";
            this.lblGPM.Size = new System.Drawing.Size(34, 13);
            this.lblGPM.TabIndex = 3;
            this.lblGPM.Text = "GPM:";
            // 
            // tbGPMM
            // 
            this.tbGPMM.Location = new System.Drawing.Point(62, 34);
            this.tbGPMM.Name = "tbGPMM";
            this.tbGPMM.ReadOnly = true;
            this.tbGPMM.Size = new System.Drawing.Size(266, 20);
            this.tbGPMM.TabIndex = 6;
            this.tpGPMM.SetToolTip(this.tbGPMM, "Medición de gotas por minuto actuales.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "GPMM: ";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(107, 90);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(90, 23);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // tbGPM
            // 
            this.tbGPM.Location = new System.Drawing.Point(62, 7);
            this.tbGPM.Maximum = new decimal(new int[] {
            99,
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
            this.lblConnStatus.Location = new System.Drawing.Point(203, 95);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(78, 13);
            this.lblConnStatus.TabIndex = 8;
            this.lblConnStatus.Text = "No conectado.";
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(9, 63);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(54, 13);
            this.lblServerIP.TabIndex = 9;
            this.lblServerIP.Text = "Server IP:";
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(62, 60);
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
            // frmMain
            // 
            this.AcceptButton = this.btnRequest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 126);
            this.Controls.Add(this.tbServerIP);
            this.Controls.Add(this.lblServerIP);
            this.Controls.Add(this.lblConnStatus);
            this.Controls.Add(this.tbGPM);
            this.Controls.Add(this.tbGPMM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGPM);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnRequest);
            this.Name = "frmMain";
            this.Text = "Control de Valvula de Aceite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbGPM)).EndInit();
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
    }
}

