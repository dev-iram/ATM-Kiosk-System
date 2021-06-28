namespace ATM_Kiosk_System
{
    partial class frmWithdrawl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWithdrawl));
            this.lblChangePin = new System.Windows.Forms.Label();
            this.pnlOnScreenKeypad = new System.Windows.Forms.Panel();
            this.txtNewPinConfirm = new System.Windows.Forms.TextBox();
            this.lblEnterNewPin = new System.Windows.Forms.Label();
            this.txtNewPin = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPin = new System.Windows.Forms.Label();
            this.grpChangePin = new System.Windows.Forms.GroupBox();
            this.lblCurrentPin = new System.Windows.Forms.Label();
            this.txtCurrentPin = new System.Windows.Forms.TextBox();
            this.pnlChangePin = new System.Windows.Forms.Panel();
            this.grpNewPIN = new System.Windows.Forms.GroupBox();
            this.ModernBankTooltip2 = new System.Windows.Forms.ToolTip(this.components);
            this.ChangePinTimer = new System.Windows.Forms.Timer(this.components);
            this.SessionTimeout = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new ePOSOne.btnProduct.Button_WOC1();
            this.btnBackToMain = new ePOSOne.btnProduct.Button_WOC1();
            this.lblValidPin2 = new ePOSOne.btnProduct.Button_WOC1();
            this.btnPinChangeNow = new ePOSOne.btnProduct.Button_WOC1();
            this.lblInvalidPin2 = new ePOSOne.btnProduct.Button_WOC1();
            this.lblValidPin1 = new ePOSOne.btnProduct.Button_WOC1();
            this.lblInvalidPin1 = new ePOSOne.btnProduct.Button_WOC1();
            this.btnCheckCurrentPin = new ePOSOne.btnProduct.Button_WOC1();
            this.lblValid = new ePOSOne.btnProduct.Button_WOC1();
            this.lblInvalid = new ePOSOne.btnProduct.Button_WOC1();
            this.btnClear = new ePOSOne.btnProduct.Button_WOC1();
            this.btn0 = new ePOSOne.btnProduct.Button_WOC1();
            this.button_WOC16 = new ePOSOne.btnProduct.Button_WOC1();
            this.btn8 = new ePOSOne.btnProduct.Button_WOC1();
            this.btn7 = new ePOSOne.btnProduct.Button_WOC1();
            this.btn6 = new ePOSOne.btnProduct.Button_WOC1();
            this.btn5 = new ePOSOne.btnProduct.Button_WOC1();
            this.btn4 = new ePOSOne.btnProduct.Button_WOC1();
            this.btn3 = new ePOSOne.btnProduct.Button_WOC1();
            this.btn2 = new ePOSOne.btnProduct.Button_WOC1();
            this.btn1 = new ePOSOne.btnProduct.Button_WOC1();
            this.pnlOnScreenKeypad.SuspendLayout();
            this.grpChangePin.SuspendLayout();
            this.pnlChangePin.SuspendLayout();
            this.grpNewPIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChangePin
            // 
            this.lblChangePin.AutoSize = true;
            this.lblChangePin.BackColor = System.Drawing.Color.Transparent;
            this.lblChangePin.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblChangePin.Location = new System.Drawing.Point(427, 13);
            this.lblChangePin.Name = "lblChangePin";
            this.lblChangePin.Size = new System.Drawing.Size(192, 40);
            this.lblChangePin.TabIndex = 21;
            this.lblChangePin.Text = "Change Pin";
            // 
            // pnlOnScreenKeypad
            // 
            this.pnlOnScreenKeypad.Controls.Add(this.btnClear);
            this.pnlOnScreenKeypad.Controls.Add(this.btn0);
            this.pnlOnScreenKeypad.Controls.Add(this.button_WOC16);
            this.pnlOnScreenKeypad.Controls.Add(this.btn8);
            this.pnlOnScreenKeypad.Controls.Add(this.btn7);
            this.pnlOnScreenKeypad.Controls.Add(this.btn6);
            this.pnlOnScreenKeypad.Controls.Add(this.btn5);
            this.pnlOnScreenKeypad.Controls.Add(this.btn4);
            this.pnlOnScreenKeypad.Controls.Add(this.btn3);
            this.pnlOnScreenKeypad.Controls.Add(this.btn2);
            this.pnlOnScreenKeypad.Controls.Add(this.btn1);
            this.pnlOnScreenKeypad.Location = new System.Drawing.Point(297, 405);
            this.pnlOnScreenKeypad.Name = "pnlOnScreenKeypad";
            this.pnlOnScreenKeypad.Size = new System.Drawing.Size(493, 410);
            this.pnlOnScreenKeypad.TabIndex = 24;
            // 
            // txtNewPinConfirm
            // 
            this.txtNewPinConfirm.Enabled = false;
            this.txtNewPinConfirm.Font = new System.Drawing.Font("Montserrat", 21.75F);
            this.txtNewPinConfirm.Location = new System.Drawing.Point(128, 147);
            this.txtNewPinConfirm.Name = "txtNewPinConfirm";
            this.txtNewPinConfirm.PasswordChar = '●';
            this.txtNewPinConfirm.Size = new System.Drawing.Size(321, 47);
            this.txtNewPinConfirm.TabIndex = 4;
            this.ModernBankTooltip2.SetToolTip(this.txtNewPinConfirm, "Please confirm your new PIN.");
            this.txtNewPinConfirm.TextChanged += new System.EventHandler(this.txtNewPinConfirm_TextChanged);
            this.txtNewPinConfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPinConfirm_KeyPress);
            // 
            // lblEnterNewPin
            // 
            this.lblEnterNewPin.AutoSize = true;
            this.lblEnterNewPin.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterNewPin.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEnterNewPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEnterNewPin.Location = new System.Drawing.Point(123, 26);
            this.lblEnterNewPin.Name = "lblEnterNewPin";
            this.lblEnterNewPin.Size = new System.Drawing.Size(304, 29);
            this.lblEnterNewPin.TabIndex = 27;
            this.lblEnterNewPin.Text = "Please enter your new PIN";
            // 
            // txtNewPin
            // 
            this.txtNewPin.Font = new System.Drawing.Font("Montserrat", 21.75F);
            this.txtNewPin.Location = new System.Drawing.Point(128, 58);
            this.txtNewPin.Name = "txtNewPin";
            this.txtNewPin.PasswordChar = '●';
            this.txtNewPin.Size = new System.Drawing.Size(321, 47);
            this.txtNewPin.TabIndex = 3;
            this.ModernBankTooltip2.SetToolTip(this.txtNewPin, "Please enter your new PIN.");
            this.txtNewPin.TextChanged += new System.EventHandler(this.txtNewPin_TextChanged);
            this.txtNewPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPin_KeyPress);
            // 
            // lblConfirmNewPin
            // 
            this.lblConfirmNewPin.AutoSize = true;
            this.lblConfirmNewPin.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmNewPin.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblConfirmNewPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblConfirmNewPin.Location = new System.Drawing.Point(105, 108);
            this.lblConfirmNewPin.Name = "lblConfirmNewPin";
            this.lblConfirmNewPin.Size = new System.Drawing.Size(333, 29);
            this.lblConfirmNewPin.TabIndex = 28;
            this.lblConfirmNewPin.Text = "Please confirm your new PIN";
            // 
            // grpChangePin
            // 
            this.grpChangePin.Controls.Add(this.lblCurrentPin);
            this.grpChangePin.Controls.Add(this.btnCheckCurrentPin);
            this.grpChangePin.Controls.Add(this.lblValid);
            this.grpChangePin.Controls.Add(this.txtCurrentPin);
            this.grpChangePin.Controls.Add(this.lblInvalid);
            this.grpChangePin.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.grpChangePin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpChangePin.Location = new System.Drawing.Point(81, 56);
            this.grpChangePin.Name = "grpChangePin";
            this.grpChangePin.Size = new System.Drawing.Size(847, 132);
            this.grpChangePin.TabIndex = 11;
            this.grpChangePin.TabStop = false;
            this.grpChangePin.Text = "Current PIN";
            // 
            // lblCurrentPin
            // 
            this.lblCurrentPin.AutoSize = true;
            this.lblCurrentPin.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPin.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCurrentPin.Location = new System.Drawing.Point(123, 22);
            this.lblCurrentPin.Name = "lblCurrentPin";
            this.lblCurrentPin.Size = new System.Drawing.Size(337, 29);
            this.lblCurrentPin.TabIndex = 22;
            this.lblCurrentPin.Text = "Please enter your current PIN";
            // 
            // txtCurrentPin
            // 
            this.txtCurrentPin.Font = new System.Drawing.Font("Montserrat", 21.75F);
            this.txtCurrentPin.Location = new System.Drawing.Point(128, 58);
            this.txtCurrentPin.Name = "txtCurrentPin";
            this.txtCurrentPin.PasswordChar = '●';
            this.txtCurrentPin.Size = new System.Drawing.Size(321, 47);
            this.txtCurrentPin.TabIndex = 1;
            this.ModernBankTooltip2.SetToolTip(this.txtCurrentPin, "Please enter your current account PIN.");
            this.txtCurrentPin.TextChanged += new System.EventHandler(this.txtCurrentPin_TextChanged);
            this.txtCurrentPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentPin_KeyPress);
            // 
            // pnlChangePin
            // 
            this.pnlChangePin.Controls.Add(this.grpNewPIN);
            this.pnlChangePin.Controls.Add(this.grpChangePin);
            this.pnlChangePin.Controls.Add(this.pnlOnScreenKeypad);
            this.pnlChangePin.Controls.Add(this.lblChangePin);
            this.pnlChangePin.Location = new System.Drawing.Point(99, 65);
            this.pnlChangePin.Name = "pnlChangePin";
            this.pnlChangePin.Size = new System.Drawing.Size(988, 833);
            this.pnlChangePin.TabIndex = 23;
            this.pnlChangePin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChangePin_Paint);
            // 
            // grpNewPIN
            // 
            this.grpNewPIN.Controls.Add(this.lblValidPin2);
            this.grpNewPIN.Controls.Add(this.btnPinChangeNow);
            this.grpNewPIN.Controls.Add(this.lblInvalidPin2);
            this.grpNewPIN.Controls.Add(this.lblValidPin1);
            this.grpNewPIN.Controls.Add(this.lblEnterNewPin);
            this.grpNewPIN.Controls.Add(this.lblConfirmNewPin);
            this.grpNewPIN.Controls.Add(this.lblInvalidPin1);
            this.grpNewPIN.Controls.Add(this.txtNewPin);
            this.grpNewPIN.Controls.Add(this.txtNewPinConfirm);
            this.grpNewPIN.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.grpNewPIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpNewPIN.Location = new System.Drawing.Point(81, 194);
            this.grpNewPIN.Name = "grpNewPIN";
            this.grpNewPIN.Size = new System.Drawing.Size(847, 205);
            this.grpNewPIN.TabIndex = 32;
            this.grpNewPIN.TabStop = false;
            this.grpNewPIN.Text = "New PIN";
            this.grpNewPIN.Visible = false;
            // 
            // ModernBankTooltip2
            // 
            this.ModernBankTooltip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip2.ForeColor = System.Drawing.Color.White;
            this.ModernBankTooltip2.OwnerDraw = true;
            this.ModernBankTooltip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ModernBankTooltip2.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.ModernBankTooltip2_Draw_1);
            this.ModernBankTooltip2.Popup += new System.Windows.Forms.PopupEventHandler(this.ModernBankTooltip2_Popup);
            // 
            // ChangePinTimer
            // 
            this.ChangePinTimer.Enabled = true;
            this.ChangePinTimer.Interval = 1000;
            this.ChangePinTimer.Tick += new System.EventHandler(this.ChangePinTimer_Tick);
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
            this.btnHelp.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnHelp.Location = new System.Drawing.Point(1227, -1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHelp.Size = new System.Drawing.Size(52, 52);
            this.btnHelp.TabIndex = 30;
            this.btnHelp.Text = "?";
            this.btnHelp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip2.SetToolTip(this.btnHelp, "Help");
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
            this.btnBackToMain.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.Location = new System.Drawing.Point(3, -1);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackToMain.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackToMain.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBackToMain.Size = new System.Drawing.Size(52, 52);
            this.btnBackToMain.TabIndex = 29;
            this.btnBackToMain.Text = "<";
            this.btnBackToMain.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip2.SetToolTip(this.btnBackToMain, "Back to Menu");
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // lblValidPin2
            // 
            this.lblValidPin2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValidPin2.ButtonColor = System.Drawing.Color.White;
            this.lblValidPin2.FlatAppearance.BorderSize = 0;
            this.lblValidPin2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.lblValidPin2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.lblValidPin2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValidPin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidPin2.Location = new System.Drawing.Point(455, 147);
            this.lblValidPin2.Name = "lblValidPin2";
            this.lblValidPin2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValidPin2.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValidPin2.OnHoverTextColor = System.Drawing.Color.White;
            this.lblValidPin2.Size = new System.Drawing.Size(47, 47);
            this.lblValidPin2.TabIndex = 35;
            this.lblValidPin2.Text = "✓";
            this.lblValidPin2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValidPin2.UseVisualStyleBackColor = true;
            this.lblValidPin2.Visible = false;
            // 
            // btnPinChangeNow
            // 
            this.btnPinChangeNow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPinChangeNow.ButtonColor = System.Drawing.Color.White;
            this.btnPinChangeNow.FlatAppearance.BorderSize = 0;
            this.btnPinChangeNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPinChangeNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPinChangeNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPinChangeNow.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPinChangeNow.Location = new System.Drawing.Point(544, 61);
            this.btnPinChangeNow.Name = "btnPinChangeNow";
            this.btnPinChangeNow.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPinChangeNow.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPinChangeNow.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPinChangeNow.Size = new System.Drawing.Size(248, 76);
            this.btnPinChangeNow.TabIndex = 5;
            this.btnPinChangeNow.Text = "Change PIN";
            this.btnPinChangeNow.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip2.SetToolTip(this.btnPinChangeNow, "Confirm your PIN changes.");
            this.btnPinChangeNow.UseVisualStyleBackColor = true;
            this.btnPinChangeNow.Visible = false;
            this.btnPinChangeNow.Click += new System.EventHandler(this.btnPinChangeNow_Click);
            // 
            // lblInvalidPin2
            // 
            this.lblInvalidPin2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalidPin2.ButtonColor = System.Drawing.Color.White;
            this.lblInvalidPin2.FlatAppearance.BorderSize = 0;
            this.lblInvalidPin2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.lblInvalidPin2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.lblInvalidPin2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInvalidPin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPin2.Location = new System.Drawing.Point(455, 147);
            this.lblInvalidPin2.Name = "lblInvalidPin2";
            this.lblInvalidPin2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalidPin2.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalidPin2.OnHoverTextColor = System.Drawing.Color.White;
            this.lblInvalidPin2.Size = new System.Drawing.Size(47, 47);
            this.lblInvalidPin2.TabIndex = 34;
            this.lblInvalidPin2.Text = "x";
            this.lblInvalidPin2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalidPin2.UseVisualStyleBackColor = true;
            this.lblInvalidPin2.Visible = false;
            // 
            // lblValidPin1
            // 
            this.lblValidPin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValidPin1.ButtonColor = System.Drawing.Color.White;
            this.lblValidPin1.FlatAppearance.BorderSize = 0;
            this.lblValidPin1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.lblValidPin1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.lblValidPin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValidPin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidPin1.Location = new System.Drawing.Point(455, 58);
            this.lblValidPin1.Name = "lblValidPin1";
            this.lblValidPin1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValidPin1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValidPin1.OnHoverTextColor = System.Drawing.Color.White;
            this.lblValidPin1.Size = new System.Drawing.Size(47, 47);
            this.lblValidPin1.TabIndex = 32;
            this.lblValidPin1.Text = "✓";
            this.lblValidPin1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValidPin1.UseVisualStyleBackColor = true;
            this.lblValidPin1.Visible = false;
            // 
            // lblInvalidPin1
            // 
            this.lblInvalidPin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalidPin1.ButtonColor = System.Drawing.Color.White;
            this.lblInvalidPin1.FlatAppearance.BorderSize = 0;
            this.lblInvalidPin1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.lblInvalidPin1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.lblInvalidPin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInvalidPin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPin1.Location = new System.Drawing.Point(455, 58);
            this.lblInvalidPin1.Name = "lblInvalidPin1";
            this.lblInvalidPin1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalidPin1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalidPin1.OnHoverTextColor = System.Drawing.Color.White;
            this.lblInvalidPin1.Size = new System.Drawing.Size(47, 47);
            this.lblInvalidPin1.TabIndex = 33;
            this.lblInvalidPin1.Text = "x";
            this.lblInvalidPin1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalidPin1.UseVisualStyleBackColor = true;
            this.lblInvalidPin1.Visible = false;
            // 
            // btnCheckCurrentPin
            // 
            this.btnCheckCurrentPin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCheckCurrentPin.ButtonColor = System.Drawing.Color.White;
            this.btnCheckCurrentPin.FlatAppearance.BorderSize = 0;
            this.btnCheckCurrentPin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCheckCurrentPin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCheckCurrentPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCurrentPin.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCheckCurrentPin.Location = new System.Drawing.Point(544, 42);
            this.btnCheckCurrentPin.Name = "btnCheckCurrentPin";
            this.btnCheckCurrentPin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCheckCurrentPin.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCheckCurrentPin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCheckCurrentPin.Size = new System.Drawing.Size(248, 76);
            this.btnCheckCurrentPin.TabIndex = 2;
            this.btnCheckCurrentPin.Text = "Verify";
            this.btnCheckCurrentPin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip2.SetToolTip(this.btnCheckCurrentPin, "Verification required in order to change PIN.");
            this.btnCheckCurrentPin.UseVisualStyleBackColor = true;
            this.btnCheckCurrentPin.Click += new System.EventHandler(this.btnCheckCurrentPin_Click);
            // 
            // lblValid
            // 
            this.lblValid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValid.ButtonColor = System.Drawing.Color.White;
            this.lblValid.FlatAppearance.BorderSize = 0;
            this.lblValid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.lblValid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.lblValid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid.Location = new System.Drawing.Point(455, 58);
            this.lblValid.Name = "lblValid";
            this.lblValid.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValid.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValid.OnHoverTextColor = System.Drawing.Color.White;
            this.lblValid.Size = new System.Drawing.Size(47, 47);
            this.lblValid.TabIndex = 31;
            this.lblValid.Text = "✓";
            this.lblValid.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValid.UseVisualStyleBackColor = true;
            this.lblValid.Visible = false;
            this.lblValid.Click += new System.EventHandler(this.lblValid_Click);
            // 
            // lblInvalid
            // 
            this.lblInvalid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalid.ButtonColor = System.Drawing.Color.White;
            this.lblInvalid.FlatAppearance.BorderSize = 0;
            this.lblInvalid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.lblInvalid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.lblInvalid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.Location = new System.Drawing.Point(455, 58);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalid.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalid.OnHoverTextColor = System.Drawing.Color.White;
            this.lblInvalid.Size = new System.Drawing.Size(47, 47);
            this.lblInvalid.TabIndex = 30;
            this.lblInvalid.Text = "x";
            this.lblInvalid.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalid.UseVisualStyleBackColor = true;
            this.lblInvalid.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.ButtonColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(170, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.Size = new System.Drawing.Size(299, 82);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn0
            // 
            this.btn0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn0.ButtonColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn0.Location = new System.Drawing.Point(14, 312);
            this.btn0.Name = "btn0";
            this.btn0.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn0.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn0.OnHoverTextColor = System.Drawing.Color.White;
            this.btn0.Size = new System.Drawing.Size(145, 82);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Allbuttons);
            // 
            // button_WOC16
            // 
            this.button_WOC16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_WOC16.ButtonColor = System.Drawing.Color.White;
            this.button_WOC16.FlatAppearance.BorderSize = 0;
            this.button_WOC16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_WOC16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_WOC16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC16.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_WOC16.Location = new System.Drawing.Point(321, 211);
            this.button_WOC16.Name = "button_WOC16";
            this.button_WOC16.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_WOC16.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_WOC16.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC16.Size = new System.Drawing.Size(145, 82);
            this.button_WOC16.TabIndex = 8;
            this.button_WOC16.Text = "9";
            this.button_WOC16.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_WOC16.UseVisualStyleBackColor = true;
            this.button_WOC16.Click += new System.EventHandler(this.Allbuttons);
            // 
            // btn8
            // 
            this.btn8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn8.ButtonColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(170, 211);
            this.btn8.Name = "btn8";
            this.btn8.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn8.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn8.OnHoverTextColor = System.Drawing.Color.White;
            this.btn8.Size = new System.Drawing.Size(145, 82);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Allbuttons);
            // 
            // btn7
            // 
            this.btn7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn7.ButtonColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn7.Location = new System.Drawing.Point(14, 211);
            this.btn7.Name = "btn7";
            this.btn7.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn7.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn7.OnHoverTextColor = System.Drawing.Color.White;
            this.btn7.Size = new System.Drawing.Size(145, 82);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Allbuttons);
            // 
            // btn6
            // 
            this.btn6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn6.ButtonColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(321, 113);
            this.btn6.Name = "btn6";
            this.btn6.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn6.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn6.OnHoverTextColor = System.Drawing.Color.White;
            this.btn6.Size = new System.Drawing.Size(145, 82);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Allbuttons);
            // 
            // btn5
            // 
            this.btn5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn5.ButtonColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(170, 113);
            this.btn5.Name = "btn5";
            this.btn5.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn5.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn5.OnHoverTextColor = System.Drawing.Color.White;
            this.btn5.Size = new System.Drawing.Size(145, 82);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Allbuttons);
            // 
            // btn4
            // 
            this.btn4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn4.ButtonColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(14, 113);
            this.btn4.Name = "btn4";
            this.btn4.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn4.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn4.OnHoverTextColor = System.Drawing.Color.White;
            this.btn4.Size = new System.Drawing.Size(145, 82);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Allbuttons);
            // 
            // btn3
            // 
            this.btn3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn3.ButtonColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(321, 16);
            this.btn3.Name = "btn3";
            this.btn3.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn3.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn3.OnHoverTextColor = System.Drawing.Color.White;
            this.btn3.Size = new System.Drawing.Size(145, 82);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Allbuttons);
            // 
            // btn2
            // 
            this.btn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn2.ButtonColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(170, 16);
            this.btn2.Name = "btn2";
            this.btn2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn2.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn2.OnHoverTextColor = System.Drawing.Color.White;
            this.btn2.Size = new System.Drawing.Size(145, 82);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Allbuttons);
            // 
            // btn1
            // 
            this.btn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn1.ButtonColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(14, 16);
            this.btn1.Name = "btn1";
            this.btn1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn1.OnHoverTextColor = System.Drawing.Color.White;
            this.btn1.Size = new System.Drawing.Size(145, 82);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Allbuttons);
            // 
            // frmWithdrawl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 910);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.pnlChangePin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWithdrawl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmWithdrawl_Load);
            this.Click += new System.EventHandler(this.frmWithdrawl_Click);
            this.pnlOnScreenKeypad.ResumeLayout(false);
            this.grpChangePin.ResumeLayout(false);
            this.grpChangePin.PerformLayout();
            this.pnlChangePin.ResumeLayout(false);
            this.pnlChangePin.PerformLayout();
            this.grpNewPIN.ResumeLayout(false);
            this.grpNewPIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ePOSOne.btnProduct.Button_WOC1 btnBackToMain;
        private ePOSOne.btnProduct.Button_WOC1 btnHelp;
        private System.Windows.Forms.Label lblChangePin;
        private System.Windows.Forms.Panel pnlOnScreenKeypad;
        private ePOSOne.btnProduct.Button_WOC1 btnClear;
        private ePOSOne.btnProduct.Button_WOC1 btn0;
        private ePOSOne.btnProduct.Button_WOC1 button_WOC16;
        private ePOSOne.btnProduct.Button_WOC1 btn8;
        private ePOSOne.btnProduct.Button_WOC1 btn7;
        private ePOSOne.btnProduct.Button_WOC1 btn6;
        private ePOSOne.btnProduct.Button_WOC1 btn5;
        private ePOSOne.btnProduct.Button_WOC1 btn4;
        private ePOSOne.btnProduct.Button_WOC1 btn3;
        private ePOSOne.btnProduct.Button_WOC1 btn2;
        private ePOSOne.btnProduct.Button_WOC1 btn1;
        private System.Windows.Forms.TextBox txtNewPinConfirm;
        private System.Windows.Forms.Label lblEnterNewPin;
        private System.Windows.Forms.TextBox txtNewPin;
        private System.Windows.Forms.Label lblConfirmNewPin;
        private ePOSOne.btnProduct.Button_WOC1 lblInvalidPin1;
        private ePOSOne.btnProduct.Button_WOC1 lblInvalidPin2;
        private ePOSOne.btnProduct.Button_WOC1 lblValidPin2;
        private ePOSOne.btnProduct.Button_WOC1 lblValidPin1;
        private ePOSOne.btnProduct.Button_WOC1 btnPinChangeNow;
        private System.Windows.Forms.GroupBox grpChangePin;
        private System.Windows.Forms.Label lblCurrentPin;
        private ePOSOne.btnProduct.Button_WOC1 btnCheckCurrentPin;
        private ePOSOne.btnProduct.Button_WOC1 lblValid;
        private System.Windows.Forms.TextBox txtCurrentPin;
        private ePOSOne.btnProduct.Button_WOC1 lblInvalid;
        private System.Windows.Forms.Panel pnlChangePin;
        private System.Windows.Forms.GroupBox grpNewPIN;
        private System.Windows.Forms.ToolTip ModernBankTooltip2;
        private System.Windows.Forms.Timer ChangePinTimer;
        private System.Windows.Forms.Timer SessionTimeout;
    }
}