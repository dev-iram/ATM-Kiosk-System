namespace ATM_Kiosk_System
{
    partial class frmCheckBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckBalance));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.lblRetrieving = new System.Windows.Forms.Label();
            this.pbxLoader = new System.Windows.Forms.PictureBox();
            this.CheckBalanceTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlCheckBalance = new System.Windows.Forms.Panel();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnHelp = new ePOSOne.btnProduct.Button_WOC1();
            this.btnBackToMain = new ePOSOne.btnProduct.Button_WOC1();
            this.ModernBankTooltip6 = new System.Windows.Forms.ToolTip(this.components);
            this.BalanceTimer = new System.Windows.Forms.Timer(this.components);
            this.SessionTimeout = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoader)).BeginInit();
            this.pnlCheckBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 140.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtInput.Location = new System.Drawing.Point(3, 228);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(1101, 219);
            this.txtInput.TabIndex = 26;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInput.Visible = false;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCurrentBalance.Location = new System.Drawing.Point(420, 65);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(263, 37);
            this.lblCurrentBalance.TabIndex = 24;
            this.lblCurrentBalance.Text = "Current Balance";
            // 
            // lblRetrieving
            // 
            this.lblRetrieving.AutoSize = true;
            this.lblRetrieving.BackColor = System.Drawing.Color.Transparent;
            this.lblRetrieving.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRetrieving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblRetrieving.Location = new System.Drawing.Point(328, 117);
            this.lblRetrieving.Name = "lblRetrieving";
            this.lblRetrieving.Size = new System.Drawing.Size(474, 25);
            this.lblRetrieving.TabIndex = 25;
            this.lblRetrieving.Text = "Please wait while we retrieve your balance..";
            // 
            // pbxLoader
            // 
            this.pbxLoader.BackColor = System.Drawing.Color.Transparent;
            this.pbxLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxLoader.Image = ((System.Drawing.Image)(resources.GetObject("pbxLoader.Image")));
            this.pbxLoader.Location = new System.Drawing.Point(465, 149);
            this.pbxLoader.Name = "pbxLoader";
            this.pbxLoader.Size = new System.Drawing.Size(217, 57);
            this.pbxLoader.TabIndex = 27;
            this.pbxLoader.TabStop = false;
            this.ModernBankTooltip6.SetToolTip(this.pbxLoader, "Loading...");
            // 
            // CheckBalanceTimer
            // 
            this.CheckBalanceTimer.Enabled = true;
            this.CheckBalanceTimer.Interval = 3000;
            this.CheckBalanceTimer.Tick += new System.EventHandler(this.CheckBalanceTimer_Tick);
            // 
            // pnlCheckBalance
            // 
            this.pnlCheckBalance.Controls.Add(this.lblAccount);
            this.pnlCheckBalance.Controls.Add(this.lblBalance);
            this.pnlCheckBalance.Controls.Add(this.lblCurrentBalance);
            this.pnlCheckBalance.Controls.Add(this.lblRetrieving);
            this.pnlCheckBalance.Controls.Add(this.pbxLoader);
            this.pnlCheckBalance.Controls.Add(this.txtInput);
            this.pnlCheckBalance.Location = new System.Drawing.Point(82, 82);
            this.pnlCheckBalance.Name = "pnlCheckBalance";
            this.pnlCheckBalance.Size = new System.Drawing.Size(1107, 641);
            this.pnlCheckBalance.TabIndex = 29;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAccount.Location = new System.Drawing.Point(802, 196);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(211, 25);
            this.lblAccount.TabIndex = 29;
            this.lblAccount.Text = "<Account Number>";
            this.ModernBankTooltip6.SetToolTip(this.lblAccount, "Account Number");
            this.lblAccount.Visible = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBalance.Location = new System.Drawing.Point(3, 196);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(279, 25);
            this.lblBalance.TabIndex = 28;
            this.lblBalance.Text = "Your current balance is...";
            this.lblBalance.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.ButtonColor = System.Drawing.Color.White;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnHelp.Location = new System.Drawing.Point(1226, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHelp.Size = new System.Drawing.Size(52, 52);
            this.btnHelp.TabIndex = 31;
            this.btnHelp.Text = "?";
            this.btnHelp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip6.SetToolTip(this.btnHelp, "Help");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackToMain.ButtonColor = System.Drawing.Color.White;
            this.btnBackToMain.FlatAppearance.BorderSize = 0;
            this.btnBackToMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBackToMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBackToMain.Location = new System.Drawing.Point(2, 0);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackToMain.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackToMain.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBackToMain.Size = new System.Drawing.Size(52, 52);
            this.btnBackToMain.TabIndex = 28;
            this.btnBackToMain.Text = "<";
            this.btnBackToMain.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip6.SetToolTip(this.btnBackToMain, "Back to Menu");
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // ModernBankTooltip6
            // 
            this.ModernBankTooltip6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip6.ForeColor = System.Drawing.Color.White;
            this.ModernBankTooltip6.OwnerDraw = true;
            this.ModernBankTooltip6.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ModernBankTooltip6.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.ModernBankTooltip6_Draw);
            this.ModernBankTooltip6.Popup += new System.Windows.Forms.PopupEventHandler(this.ModernBankTooltip6_Popup);
            // 
            // BalanceTimer
            // 
            this.BalanceTimer.Enabled = true;
            this.BalanceTimer.Interval = 1000;
            this.BalanceTimer.Tick += new System.EventHandler(this.BalanceTimer_Tick);
            // 
            // SessionTimeout
            // 
            this.SessionTimeout.Interval = 1000;
            this.SessionTimeout.Tick += new System.EventHandler(this.SessionTimeout_Tick);
            // 
            // frmCheckBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 879);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pnlCheckBalance);
            this.Controls.Add(this.btnBackToMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCheckBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckBalance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCheckBalance_Load);
            this.Click += new System.EventHandler(this.frmCheckBalance_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoader)).EndInit();
            this.pnlCheckBalance.ResumeLayout(false);
            this.pnlCheckBalance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Label lblRetrieving;
        private System.Windows.Forms.PictureBox pbxLoader;
        private System.Windows.Forms.Timer CheckBalanceTimer;
        private ePOSOne.btnProduct.Button_WOC1 btnBackToMain;
        private System.Windows.Forms.Panel pnlCheckBalance;
        private ePOSOne.btnProduct.Button_WOC1 btnHelp;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ToolTip ModernBankTooltip6;
        private System.Windows.Forms.Timer BalanceTimer;
        private System.Windows.Forms.Timer SessionTimeout;
    }
}