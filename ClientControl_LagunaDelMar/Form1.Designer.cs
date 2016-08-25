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
            this.btnRequest = new System.Windows.Forms.Button();
            this.lblGrados = new System.Windows.Forms.Label();
            this.tbGrados = new System.Windows.Forms.TextBox();
            this.lblGPM = new System.Windows.Forms.Label();
            this.tbGPMM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tbGPM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbGPM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(12, 83);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 0;
            this.btnRequest.Text = "Enviar";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // lblGrados
            // 
            this.lblGrados.AutoSize = true;
            this.lblGrados.Location = new System.Drawing.Point(9, 34);
            this.lblGrados.Name = "lblGrados";
            this.lblGrados.Size = new System.Drawing.Size(47, 13);
            this.lblGrados.TabIndex = 1;
            this.lblGrados.Text = "Grados: ";
            // 
            // tbGrados
            // 
            this.tbGrados.Location = new System.Drawing.Point(62, 31);
            this.tbGrados.Name = "tbGrados";
            this.tbGrados.ReadOnly = true;
            this.tbGrados.Size = new System.Drawing.Size(266, 20);
            this.tbGrados.TabIndex = 2;
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
            this.tbGPMM.Location = new System.Drawing.Point(62, 57);
            this.tbGPMM.Name = "tbGPMM";
            this.tbGPMM.ReadOnly = true;
            this.tbGPMM.Size = new System.Drawing.Size(266, 20);
            this.tbGPMM.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "GPMM: ";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(93, 83);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tbGPM
            // 
            this.tbGPM.Location = new System.Drawing.Point(62, 7);
            this.tbGPM.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.tbGPM.Name = "tbGPM";
            this.tbGPM.Size = new System.Drawing.Size(266, 20);
            this.tbGPM.TabIndex = 7;
            this.tbGPM.ValueChanged += new System.EventHandler(this.tbGPM_ValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 115);
            this.Controls.Add(this.tbGPM);
            this.Controls.Add(this.tbGPMM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGPM);
            this.Controls.Add(this.tbGrados);
            this.Controls.Add(this.lblGrados);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRequest);
            this.Name = "frmMain";
            this.Text = "Control de Valvula de Aceite";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbGPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label lblGrados;
        private System.Windows.Forms.TextBox tbGrados;
        private System.Windows.Forms.Label lblGPM;
        private System.Windows.Forms.TextBox tbGPMM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.NumericUpDown tbGPM;
    }
}

