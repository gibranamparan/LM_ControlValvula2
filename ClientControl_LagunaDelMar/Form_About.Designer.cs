namespace ClientControl_LagunaDelMar
{
    partial class Form_About
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
            this.tbInfo = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkNetcode = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(12, 94);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(550, 83);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientControl_LagunaDelMar.Properties.Resources.laguna_del_mar_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(81, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // linkNetcode
            // 
            this.linkNetcode.AutoSize = true;
            this.linkNetcode.Location = new System.Drawing.Point(412, 180);
            this.linkNetcode.Name = "linkNetcode";
            this.linkNetcode.Size = new System.Drawing.Size(150, 13);
            this.linkNetcode.TabIndex = 2;
            this.linkNetcode.TabStop = true;
            this.linkNetcode.Text = "Hecho por Netcode Solutions.";
            this.linkNetcode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNetcode_LinkClicked);
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 204);
            this.Controls.Add(this.linkNetcode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbInfo);
            this.Name = "Form_About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.Form_About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkNetcode;
    }
}