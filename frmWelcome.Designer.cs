namespace ATM_Kiosk_System
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbxLoader = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(109, 261);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(374, 29);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Please touch the screen to begin";
            this.lblMessage.Click += new System.EventHandler(this.label3_Click);
            // 
            // pbxLoader
            // 
            this.pbxLoader.BackColor = System.Drawing.Color.Transparent;
            this.pbxLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxLoader.Image = ((System.Drawing.Image)(resources.GetObject("pbxLoader.Image")));
            this.pbxLoader.Location = new System.Drawing.Point(185, 302);
            this.pbxLoader.Name = "pbxLoader";
            this.pbxLoader.Size = new System.Drawing.Size(217, 57);
            this.pbxLoader.TabIndex = 4;
            this.pbxLoader.TabStop = false;
            this.pbxLoader.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(185, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(190, 201);
            this.pbxLogo.TabIndex = 5;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.Transparent;
            this.pnlWelcome.Controls.Add(this.pbxLoader);
            this.pnlWelcome.Controls.Add(this.pbxLogo);
            this.pnlWelcome.Controls.Add(this.lblMessage);
            this.pnlWelcome.Location = new System.Drawing.Point(161, 205);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(567, 493);
            this.pnlWelcome.TabIndex = 6;
            this.pnlWelcome.Click += new System.EventHandler(this.pnlWelcome_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1073, 835);
            this.Controls.Add(this.pnlWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM | Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.Click += new System.EventHandler(this.frmWelcome_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pbxLoader;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pnlWelcome;
    }
}

