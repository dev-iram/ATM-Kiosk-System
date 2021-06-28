namespace ATM_Kiosk_System
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.pnlOnScreenKeypad = new System.Windows.Forms.Panel();
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
            this.txtAccountPin = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new ePOSOne.btnProduct.Button_WOC1();
            this.lblAccountDetails = new System.Windows.Forms.Label();
            this.LoginTimer = new System.Windows.Forms.Timer(this.components);
            this.SessionTimeout = new System.Windows.Forms.Timer(this.components);
            this.ModernBankTooltip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHelp = new ePOSOne.btnProduct.Button_WOC1();
            this.btnClose = new ePOSOne.btnProduct.Button_WOC1();
            this.pnlOnScreenKeypad.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountNo.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAccountNo.Location = new System.Drawing.Point(135, 59);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(200, 29);
            this.lblAccountNo.TabIndex = 3;
            this.lblAccountNo.Text = "Account Number";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Italic);
            this.txtAccountNo.Location = new System.Drawing.Point(90, 91);
            this.txtAccountNo.Multiline = true;
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(298, 49);
            this.txtAccountNo.TabIndex = 1;
            this.ModernBankTooltip1.SetToolTip(this.txtAccountNo, "Account Number should be no longer than 8 numbers. (XXXXXXXX)");
            this.txtAccountNo.TextChanged += new System.EventHandler(this.txtAccountNo_TextChanged);
            this.txtAccountNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            this.txtAccountNo.MouseEnter += new System.EventHandler(this.txtAccountNo_MouseEnter);
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.BackColor = System.Drawing.Color.Transparent;
            this.lblPin.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPin.Location = new System.Drawing.Point(215, 152);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(52, 29);
            this.lblPin.TabIndex = 8;
            this.lblPin.Text = "PIN";
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
            this.pnlOnScreenKeypad.Location = new System.Drawing.Point(190, 375);
            this.pnlOnScreenKeypad.Name = "pnlOnScreenKeypad";
            this.pnlOnScreenKeypad.Size = new System.Drawing.Size(493, 410);
            this.pnlOnScreenKeypad.TabIndex = 9;
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
            this.btnClear.TabIndex = 14;
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
            this.btn0.TabIndex = 13;
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
            this.button_WOC16.TabIndex = 12;
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
            this.btn8.TabIndex = 11;
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
            this.btn7.TabIndex = 10;
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
            this.btn6.TabIndex = 9;
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
            this.btn5.TabIndex = 8;
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
            this.btn4.TabIndex = 7;
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
            this.btn3.TabIndex = 6;
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
            this.btn2.TabIndex = 5;
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
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Allbuttons);
            // 
            // txtAccountPin
            // 
            this.txtAccountPin.Font = new System.Drawing.Font("Montserrat", 21.75F);
            this.txtAccountPin.Location = new System.Drawing.Point(90, 184);
            this.txtAccountPin.Multiline = true;
            this.txtAccountPin.Name = "txtAccountPin";
            this.txtAccountPin.PasswordChar = '●';
            this.txtAccountPin.Size = new System.Drawing.Size(298, 49);
            this.txtAccountPin.TabIndex = 2;
            this.ModernBankTooltip1.SetToolTip(this.txtAccountPin, "Account PIN should be no longer than 4 characters. (XXXX)");
            this.txtAccountPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountPin_KeyPress);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.grpLogin);
            this.pnlLogin.Controls.Add(this.lblAccountDetails);
            this.pnlLogin.Controls.Add(this.pnlOnScreenKeypad);
            this.pnlLogin.Location = new System.Drawing.Point(177, 45);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(864, 798);
            this.pnlLogin.TabIndex = 12;
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.lblAccountNo);
            this.grpLogin.Controls.Add(this.lblPin);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtAccountPin);
            this.grpLogin.Controls.Add(this.txtAccountNo);
            this.grpLogin.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.grpLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpLogin.Location = new System.Drawing.Point(49, 66);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(724, 303);
            this.grpLogin.TabIndex = 13;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Account Credentials";
            // 
            // btnLogin
            // 
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.ButtonColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(436, 105);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.Size = new System.Drawing.Size(248, 76);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip1.SetToolTip(this.btnLogin, "Valid account credentials required to access system");
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblAccountDetails
            // 
            this.lblAccountDetails.AutoSize = true;
            this.lblAccountDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountDetails.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAccountDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAccountDetails.Location = new System.Drawing.Point(240, 20);
            this.lblAccountDetails.Name = "lblAccountDetails";
            this.lblAccountDetails.Size = new System.Drawing.Size(384, 29);
            this.lblAccountDetails.TabIndex = 12;
            this.lblAccountDetails.Text = "Please enter your Account Details";
            this.lblAccountDetails.Click += new System.EventHandler(this.lblAccountDetails_Click);
            // 
            // LoginTimer
            // 
            this.LoginTimer.Enabled = true;
            this.LoginTimer.Interval = 1000;
            this.LoginTimer.Tick += new System.EventHandler(this.LoginTimer_Tick);
            // 
            // SessionTimeout
            // 
            this.SessionTimeout.Interval = 1000;
            this.SessionTimeout.Tick += new System.EventHandler(this.SessionTimeout_Tick);
            // 
            // ModernBankTooltip1
            // 
            this.ModernBankTooltip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip1.ForeColor = System.Drawing.Color.White;
            this.ModernBankTooltip1.OwnerDraw = true;
            this.ModernBankTooltip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ModernBankTooltip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.ModernBankTooltip1_Draw);
            this.ModernBankTooltip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ModernBankTooltip1_Popup);
            // 
            // btnHelp
            // 
            this.btnHelp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.ButtonColor = System.Drawing.Color.White;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(1168, -1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHelp.Size = new System.Drawing.Size(52, 52);
            this.btnHelp.TabIndex = 15;
            this.btnHelp.Text = "?";
            this.btnHelp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip1.SetToolTip(this.btnHelp, "Help");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.ButtonColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1226, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(52, 52);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "x";
            this.btnClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 879);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Click += new System.EventHandler(this.frmLogin_Click);
            this.pnlOnScreenKeypad.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Panel pnlOnScreenKeypad;
        private System.Windows.Forms.TextBox txtAccountPin;
        private ePOSOne.btnProduct.Button_WOC1 btn1;
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
        private ePOSOne.btnProduct.Button_WOC1 btnClose;
        private System.Windows.Forms.Panel pnlLogin;
        private ePOSOne.btnProduct.Button_WOC1 btnLogin;
        private System.Windows.Forms.Label lblAccountDetails;
        private System.Windows.Forms.Timer LoginTimer;
        private System.Windows.Forms.Timer SessionTimeout;
        private ePOSOne.btnProduct.Button_WOC1 btnHelp;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.ToolTip ModernBankTooltip1;
    }
}