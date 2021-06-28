namespace ATM_Kiosk_System
{
    partial class frmTransactionHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionHistory));
            this.lblAccountDetails = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.ModernBankTooltip5 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHelp = new ePOSOne.btnProduct.Button_WOC1();
            this.btnBackToMain = new ePOSOne.btnProduct.Button_WOC1();
            this.SessionTimeout = new System.Windows.Forms.Timer(this.components);
            this.TransactionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountDetails
            // 
            this.lblAccountDetails.AutoSize = true;
            this.lblAccountDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountDetails.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAccountDetails.Location = new System.Drawing.Point(524, 42);
            this.lblAccountDetails.Name = "lblAccountDetails";
            this.lblAccountDetails.Size = new System.Drawing.Size(380, 48);
            this.lblAccountDetails.TabIndex = 22;
            this.lblAccountDetails.Text = "Transaction History";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(0, 99);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.Size = new System.Drawing.Size(1277, 918);
            this.dgvTransactions.TabIndex = 23;
            this.ModernBankTooltip5.SetToolTip(this.dgvTransactions, "Displays most recent transactions");
            this.dgvTransactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellClick);
            this.dgvTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellContentClick);
            // 
            // ModernBankTooltip5
            // 
            this.ModernBankTooltip5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip5.ForeColor = System.Drawing.Color.White;
            this.ModernBankTooltip5.OwnerDraw = true;
            this.ModernBankTooltip5.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ModernBankTooltip5.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.ModernBankTooltip5_Draw);
            this.ModernBankTooltip5.Popup += new System.Windows.Forms.PopupEventHandler(this.ModernBankTooltip5_Popup);
            // 
            // btnHelp
            // 
            this.btnHelp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.ButtonColor = System.Drawing.Color.White;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnHelp.Location = new System.Drawing.Point(1225, 5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHelp.Size = new System.Drawing.Size(52, 52);
            this.btnHelp.TabIndex = 89;
            this.btnHelp.Text = "?";
            this.btnHelp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip5.SetToolTip(this.btnHelp, "Help");
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
            this.btnBackToMain.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBackToMain.Location = new System.Drawing.Point(0, 5);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackToMain.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackToMain.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBackToMain.Size = new System.Drawing.Size(52, 52);
            this.btnBackToMain.TabIndex = 30;
            this.btnBackToMain.Text = "<";
            this.btnBackToMain.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip5.SetToolTip(this.btnBackToMain, "Back to Menu");
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // SessionTimeout
            // 
            this.SessionTimeout.Interval = 1000;
            this.SessionTimeout.Tick += new System.EventHandler(this.SessionTimeout_Tick);
            // 
            // TransactionTimer
            // 
            this.TransactionTimer.Enabled = true;
            this.TransactionTimer.Interval = 1000;
            this.TransactionTimer.Tick += new System.EventHandler(this.TransactionTimer_Tick);
            // 
            // frmTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 1021);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.lblAccountDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTransactionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransactionHistory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTransactionHistory_Load);
            this.Click += new System.EventHandler(this.frmTransactionHistory_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountDetails;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private ePOSOne.btnProduct.Button_WOC1 btnBackToMain;
        private ePOSOne.btnProduct.Button_WOC1 btnHelp;
        private System.Windows.Forms.ToolTip ModernBankTooltip5;
        private System.Windows.Forms.Timer SessionTimeout;
        private System.Windows.Forms.Timer TransactionTimer;
    }
}