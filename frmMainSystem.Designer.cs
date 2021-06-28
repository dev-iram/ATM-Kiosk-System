namespace ATM_Kiosk_System
{
    partial class frmMainSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainSystem));
            this.lblAccountDetails = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.ModernBankTooltip7 = new System.Windows.Forms.ToolTip(this.components);
            this.MenuTimer = new System.Windows.Forms.Timer(this.components);
            this.SessionTimeout = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new ePOSOne.btnProduct.Button_WOC1();
            this.btnTransactionHistory = new ePOSOne.btnProduct.Button_WOC1();
            this.btnClose = new ePOSOne.btnProduct.Button_WOC1();
            this.btnCancel = new ePOSOne.btnProduct.Button_WOC1();
            this.btnEditPersonalDetails = new ePOSOne.btnProduct.Button_WOC1();
            this.btnTransfer = new ePOSOne.btnProduct.Button_WOC1();
            this.btnCheckBalance = new ePOSOne.btnProduct.Button_WOC1();
            this.btnChangePin = new ePOSOne.btnProduct.Button_WOC1();
            this.SuspendLayout();
            // 
            // lblAccountDetails
            // 
            this.lblAccountDetails.AutoSize = true;
            this.lblAccountDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountDetails.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAccountDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAccountDetails.Location = new System.Drawing.Point(447, 81);
            this.lblAccountDetails.Name = "lblAccountDetails";
            this.lblAccountDetails.Size = new System.Drawing.Size(420, 29);
            this.lblAccountDetails.TabIndex = 20;
            this.lblAccountDetails.Text = "Please select from the options below";
            this.lblAccountDetails.Click += new System.EventHandler(this.lblAccountDetails_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblWelcome.Location = new System.Drawing.Point(467, 37);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(518, 44);
            this.lblWelcome.TabIndex = 22;
            this.lblWelcome.Text = "Welcome back, <First Name>!";
            // 
            // ModernBankTooltip7
            // 
            this.ModernBankTooltip7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip7.ForeColor = System.Drawing.Color.White;
            this.ModernBankTooltip7.OwnerDraw = true;
            this.ModernBankTooltip7.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ModernBankTooltip7.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.ModernBankTooltip7_Draw);
            this.ModernBankTooltip7.Popup += new System.Windows.Forms.PopupEventHandler(this.ModernBankTooltip7_Popup);
            // 
            // MenuTimer
            // 
            this.MenuTimer.Enabled = true;
            this.MenuTimer.Interval = 1000;
            this.MenuTimer.Tick += new System.EventHandler(this.MenuTimer_Tick);
            // 
            // SessionTimeout
            // 
            this.SessionTimeout.Interval = 1000;
            this.SessionTimeout.Tick += new System.EventHandler(this.SessionTimeout_Tick);
            // 
            // btnHelp
            // 
            this.btnHelp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.ButtonColor = System.Drawing.Color.White;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnHelp.Location = new System.Drawing.Point(1166, -1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHelp.Size = new System.Drawing.Size(52, 52);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "?";
            this.btnHelp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip7.SetToolTip(this.btnHelp, "Help");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.button_WOC11_Click_1);
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTransactionHistory.ButtonColor = System.Drawing.Color.White;
            this.btnTransactionHistory.FlatAppearance.BorderSize = 0;
            this.btnTransactionHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTransactionHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionHistory.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnTransactionHistory.Location = new System.Drawing.Point(776, 415);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTransactionHistory.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTransactionHistory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTransactionHistory.Size = new System.Drawing.Size(500, 135);
            this.btnTransactionHistory.TabIndex = 5;
            this.btnTransactionHistory.Text = "Transaction History";
            this.btnTransactionHistory.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip7.SetToolTip(this.btnTransactionHistory, "View recent transactions");
            this.btnTransactionHistory.UseVisualStyleBackColor = true;
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.ButtonColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1224, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(52, 52);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "x";
            this.btnClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip7.SetToolTip(this.btnClose, "Exit");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.ButtonColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(776, 613);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.Size = new System.Drawing.Size(500, 135);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Exit";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip7.SetToolTip(this.btnCancel, "Exit");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditPersonalDetails
            // 
            this.btnEditPersonalDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditPersonalDetails.ButtonColor = System.Drawing.Color.White;
            this.btnEditPersonalDetails.FlatAppearance.BorderSize = 0;
            this.btnEditPersonalDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEditPersonalDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEditPersonalDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPersonalDetails.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnEditPersonalDetails.Location = new System.Drawing.Point(-1, 613);
            this.btnEditPersonalDetails.Name = "btnEditPersonalDetails";
            this.btnEditPersonalDetails.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditPersonalDetails.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditPersonalDetails.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditPersonalDetails.Size = new System.Drawing.Size(500, 135);
            this.btnEditPersonalDetails.TabIndex = 3;
            this.btnEditPersonalDetails.Text = "View/Edit Personal Details";
            this.btnEditPersonalDetails.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip7.SetToolTip(this.btnEditPersonalDetails, "View and Edit Personal Details. View Banking Details (Non-modifiable)");
            this.btnEditPersonalDetails.UseVisualStyleBackColor = true;
            this.btnEditPersonalDetails.Click += new System.EventHandler(this.btnEditPersonalDetails_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTransfer.ButtonColor = System.Drawing.Color.White;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.Location = new System.Drawing.Point(776, 217);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTransfer.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTransfer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTransfer.Size = new System.Drawing.Size(500, 135);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip7.SetToolTip(this.btnTransfer, "Transfer funds between account payees");
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCheckBalance.ButtonColor = System.Drawing.Color.White;
            this.btnCheckBalance.FlatAppearance.BorderSize = 0;
            this.btnCheckBalance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCheckBalance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBalance.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnCheckBalance.Location = new System.Drawing.Point(-1, 415);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCheckBalance.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCheckBalance.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCheckBalance.Size = new System.Drawing.Size(500, 135);
            this.btnCheckBalance.TabIndex = 2;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip7.SetToolTip(this.btnCheckBalance, "Check account balance");
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnChangePin
            // 
            this.btnChangePin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChangePin.ButtonColor = System.Drawing.Color.White;
            this.btnChangePin.FlatAppearance.BorderSize = 0;
            this.btnChangePin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChangePin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnChangePin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePin.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePin.Location = new System.Drawing.Point(-1, 221);
            this.btnChangePin.Name = "btnChangePin";
            this.btnChangePin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChangePin.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChangePin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChangePin.Size = new System.Drawing.Size(500, 135);
            this.btnChangePin.TabIndex = 1;
            this.btnChangePin.Text = "Change Pin";
            this.btnChangePin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip7.SetToolTip(this.btnChangePin, "Change your account PIN");
            this.btnChangePin.UseVisualStyleBackColor = true;
            this.btnChangePin.Click += new System.EventHandler(this.button_WOC11_Click);
            // 
            // frmMainSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 1018);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnTransactionHistory);
            this.Controls.Add(this.lblAccountDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditPersonalDetails);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnChangePin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainSystem_Load);
            this.Click += new System.EventHandler(this.frmMainSystem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ePOSOne.btnProduct.Button_WOC1 btnChangePin;
        private ePOSOne.btnProduct.Button_WOC1 btnCheckBalance;
        private ePOSOne.btnProduct.Button_WOC1 btnTransfer;
        private ePOSOne.btnProduct.Button_WOC1 btnEditPersonalDetails;
        private ePOSOne.btnProduct.Button_WOC1 btnCancel;
        private ePOSOne.btnProduct.Button_WOC1 btnClose;
        private System.Windows.Forms.Label lblAccountDetails;
        private ePOSOne.btnProduct.Button_WOC1 btnTransactionHistory;
        private System.Windows.Forms.Label lblWelcome;
        private ePOSOne.btnProduct.Button_WOC1 btnHelp;
        private System.Windows.Forms.ToolTip ModernBankTooltip7;
        private System.Windows.Forms.Timer MenuTimer;
        private System.Windows.Forms.Timer SessionTimeout;
    }
}