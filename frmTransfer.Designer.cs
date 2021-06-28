namespace ATM_Kiosk_System
{
    partial class frmTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfer));
            this.lblTransferPayee = new System.Windows.Forms.Label();
            this.pnlOnScreenKeypad = new System.Windows.Forms.Panel();
            this.btnDot = new ePOSOne.btnProduct.Button_WOC1();
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
            this.txtCashInput = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.PayeeAccount = new System.Windows.Forms.ComboBox();
            this.lblSelectPayee = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblValid = new ePOSOne.btnProduct.Button_WOC1();
            this.lblInvalid = new ePOSOne.btnProduct.Button_WOC1();
            this.btnTransferFunds = new ePOSOne.btnProduct.Button_WOC1();
            this.btnBackToMain = new ePOSOne.btnProduct.Button_WOC1();
            this.btnHelp = new ePOSOne.btnProduct.Button_WOC1();
            this.pnlTransfer = new System.Windows.Forms.Panel();
            this.grpTransfer = new System.Windows.Forms.GroupBox();
            this.ModernBankTooltip4 = new System.Windows.Forms.ToolTip(this.components);
            this.TransferTimer = new System.Windows.Forms.Timer(this.components);
            this.SessionTimeout = new System.Windows.Forms.Timer(this.components);
            this.pnlOnScreenKeypad.SuspendLayout();
            this.pnlTransfer.SuspendLayout();
            this.grpTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTransferPayee
            // 
            this.lblTransferPayee.AutoSize = true;
            this.lblTransferPayee.BackColor = System.Drawing.Color.Transparent;
            this.lblTransferPayee.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferPayee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTransferPayee.Location = new System.Drawing.Point(377, 11);
            this.lblTransferPayee.Name = "lblTransferPayee";
            this.lblTransferPayee.Size = new System.Drawing.Size(313, 44);
            this.lblTransferPayee.TabIndex = 24;
            this.lblTransferPayee.Text = "Transfer to Payee";
            // 
            // pnlOnScreenKeypad
            // 
            this.pnlOnScreenKeypad.Controls.Add(this.btnDot);
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
            this.pnlOnScreenKeypad.Location = new System.Drawing.Point(291, 407);
            this.pnlOnScreenKeypad.Name = "pnlOnScreenKeypad";
            this.pnlOnScreenKeypad.Size = new System.Drawing.Size(493, 410);
            this.pnlOnScreenKeypad.TabIndex = 28;
            // 
            // btnDot
            // 
            this.btnDot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDot.ButtonColor = System.Drawing.Color.White;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(170, 312);
            this.btnDot.Name = "btnDot";
            this.btnDot.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDot.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDot.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDot.Size = new System.Drawing.Size(148, 82);
            this.btnDot.TabIndex = 11;
            this.btnDot.Text = ".";
            this.btnDot.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.AllButtons);
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.ButtonColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(321, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.Size = new System.Drawing.Size(148, 82);
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
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn0.Click += new System.EventHandler(this.AllButtons);
            // 
            // button_WOC16
            // 
            this.button_WOC16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_WOC16.ButtonColor = System.Drawing.Color.White;
            this.button_WOC16.FlatAppearance.BorderSize = 0;
            this.button_WOC16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_WOC16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_WOC16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button_WOC16.Click += new System.EventHandler(this.AllButtons);
            // 
            // btn8
            // 
            this.btn8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn8.ButtonColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn8.Click += new System.EventHandler(this.AllButtons);
            // 
            // btn7
            // 
            this.btn7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn7.ButtonColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn7.Click += new System.EventHandler(this.AllButtons);
            // 
            // btn6
            // 
            this.btn6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn6.ButtonColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn6.Click += new System.EventHandler(this.AllButtons);
            // 
            // btn5
            // 
            this.btn5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn5.ButtonColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn5.Click += new System.EventHandler(this.AllButtons);
            // 
            // btn4
            // 
            this.btn4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn4.ButtonColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn4.Click += new System.EventHandler(this.AllButtons);
            // 
            // btn3
            // 
            this.btn3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn3.ButtonColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn3.Click += new System.EventHandler(this.AllButtons);
            // 
            // btn2
            // 
            this.btn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn2.ButtonColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn2.Click += new System.EventHandler(this.AllButtons);
            // 
            // btn1
            // 
            this.btn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn1.ButtonColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn1.Click += new System.EventHandler(this.AllButtons);
            // 
            // txtCashInput
            // 
            this.txtCashInput.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashInput.Location = new System.Drawing.Point(236, 164);
            this.txtCashInput.Name = "txtCashInput";
            this.txtCashInput.Size = new System.Drawing.Size(316, 56);
            this.txtCashInput.TabIndex = 3;
            this.ModernBankTooltip4.SetToolTip(this.txtCashInput, "Currency - €");
            this.txtCashInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtCashInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAmount.Location = new System.Drawing.Point(187, 132);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(434, 29);
            this.lblAmount.TabIndex = 26;
            this.lblAmount.Text = "How much would you like to transfer?";
            // 
            // PayeeAccount
            // 
            this.PayeeAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PayeeAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PayeeAccount.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Italic);
            this.PayeeAccount.FormattingEnabled = true;
            this.PayeeAccount.Location = new System.Drawing.Point(86, 58);
            this.PayeeAccount.Name = "PayeeAccount";
            this.PayeeAccount.Size = new System.Drawing.Size(270, 48);
            this.PayeeAccount.TabIndex = 1;
            this.ModernBankTooltip4.SetToolTip(this.PayeeAccount, "Select a Payee from the list");
            this.PayeeAccount.SelectedIndexChanged += new System.EventHandler(this.PayeeAccount_SelectedIndexChanged);
            this.PayeeAccount.Click += new System.EventHandler(this.PayeeAccount_Click);
            // 
            // lblSelectPayee
            // 
            this.lblSelectPayee.AutoSize = true;
            this.lblSelectPayee.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectPayee.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSelectPayee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSelectPayee.Location = new System.Drawing.Point(149, 26);
            this.lblSelectPayee.Name = "lblSelectPayee";
            this.lblSelectPayee.Size = new System.Drawing.Size(152, 29);
            this.lblSelectPayee.TabIndex = 36;
            this.lblSelectPayee.Text = "Select Payee";
            this.lblSelectPayee.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBalance.Location = new System.Drawing.Point(73, 27);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(127, 29);
            this.lblBalance.TabIndex = 83;
            this.lblBalance.Text = "<Balance>";
            this.ModernBankTooltip4.SetToolTip(this.lblBalance, "Current Balance");
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAccountNumber.Location = new System.Drawing.Point(73, -2);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(226, 29);
            this.lblAccountNumber.TabIndex = 82;
            this.lblAccountNumber.Text = "<Account Number>";
            this.ModernBankTooltip4.SetToolTip(this.lblAccountNumber, "Account Number");
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblDescription.Location = new System.Drawing.Point(512, 26);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(139, 29);
            this.lblDescription.TabIndex = 84;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Italic);
            this.txtDescription.Location = new System.Drawing.Point(422, 58);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(316, 47);
            this.txtDescription.TabIndex = 2;
            this.ModernBankTooltip4.SetToolTip(this.txtDescription, "This will be displayed on transactions and statements.");
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
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
            this.lblValid.Location = new System.Drawing.Point(558, 173);
            this.lblValid.Name = "lblValid";
            this.lblValid.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValid.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValid.OnHoverTextColor = System.Drawing.Color.White;
            this.lblValid.Size = new System.Drawing.Size(33, 32);
            this.lblValid.TabIndex = 87;
            this.lblValid.Text = "✓";
            this.lblValid.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblValid.UseVisualStyleBackColor = true;
            this.lblValid.Visible = false;
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
            this.lblInvalid.Location = new System.Drawing.Point(558, 173);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalid.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalid.OnHoverTextColor = System.Drawing.Color.White;
            this.lblInvalid.Size = new System.Drawing.Size(33, 32);
            this.lblInvalid.TabIndex = 86;
            this.lblInvalid.Text = "x";
            this.lblInvalid.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInvalid.UseVisualStyleBackColor = true;
            this.lblInvalid.Visible = false;
            // 
            // btnTransferFunds
            // 
            this.btnTransferFunds.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTransferFunds.ButtonColor = System.Drawing.Color.White;
            this.btnTransferFunds.FlatAppearance.BorderSize = 0;
            this.btnTransferFunds.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTransferFunds.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTransferFunds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferFunds.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnTransferFunds.Location = new System.Drawing.Point(284, 238);
            this.btnTransferFunds.Name = "btnTransferFunds";
            this.btnTransferFunds.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTransferFunds.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTransferFunds.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTransferFunds.Size = new System.Drawing.Size(248, 76);
            this.btnTransferFunds.TabIndex = 4;
            this.btnTransferFunds.Text = "Transfer funds";
            this.btnTransferFunds.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip4.SetToolTip(this.btnTransferFunds, "Transfer funds. Any unsaved data will be lost.");
            this.btnTransferFunds.UseVisualStyleBackColor = true;
            this.btnTransferFunds.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.btnBackToMain.Location = new System.Drawing.Point(3, -2);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackToMain.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackToMain.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBackToMain.Size = new System.Drawing.Size(52, 52);
            this.btnBackToMain.TabIndex = 32;
            this.btnBackToMain.Text = "<";
            this.btnBackToMain.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip4.SetToolTip(this.btnBackToMain, "Back to Menu");
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
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
            this.btnHelp.Location = new System.Drawing.Point(1225, -2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHelp.Size = new System.Drawing.Size(52, 52);
            this.btnHelp.TabIndex = 88;
            this.btnHelp.Text = "?";
            this.btnHelp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip4.SetToolTip(this.btnHelp, "Help");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pnlTransfer
            // 
            this.pnlTransfer.Controls.Add(this.grpTransfer);
            this.pnlTransfer.Controls.Add(this.lblTransferPayee);
            this.pnlTransfer.Controls.Add(this.pnlOnScreenKeypad);
            this.pnlTransfer.Location = new System.Drawing.Point(78, 59);
            this.pnlTransfer.Name = "pnlTransfer";
            this.pnlTransfer.Size = new System.Drawing.Size(1062, 894);
            this.pnlTransfer.TabIndex = 89;
            this.pnlTransfer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTransfer_Paint);
            // 
            // grpTransfer
            // 
            this.grpTransfer.Controls.Add(this.PayeeAccount);
            this.grpTransfer.Controls.Add(this.lblValid);
            this.grpTransfer.Controls.Add(this.lblSelectPayee);
            this.grpTransfer.Controls.Add(this.btnTransferFunds);
            this.grpTransfer.Controls.Add(this.txtDescription);
            this.grpTransfer.Controls.Add(this.lblAmount);
            this.grpTransfer.Controls.Add(this.lblDescription);
            this.grpTransfer.Controls.Add(this.lblInvalid);
            this.grpTransfer.Controls.Add(this.txtCashInput);
            this.grpTransfer.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.grpTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpTransfer.Location = new System.Drawing.Point(124, 81);
            this.grpTransfer.Name = "grpTransfer";
            this.grpTransfer.Size = new System.Drawing.Size(792, 320);
            this.grpTransfer.TabIndex = 88;
            this.grpTransfer.TabStop = false;
            this.grpTransfer.Text = "Transfer Information";
            // 
            // ModernBankTooltip4
            // 
            this.ModernBankTooltip4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip4.ForeColor = System.Drawing.Color.White;
            this.ModernBankTooltip4.OwnerDraw = true;
            this.ModernBankTooltip4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ModernBankTooltip4.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.ModernBankTooltip4_Draw);
            this.ModernBankTooltip4.Popup += new System.Windows.Forms.PopupEventHandler(this.ModernBankTooltip4_Popup);
            // 
            // TransferTimer
            // 
            this.TransferTimer.Enabled = true;
            this.TransferTimer.Interval = 1000;
            this.TransferTimer.Tick += new System.EventHandler(this.TransferTimer_Tick);
            // 
            // SessionTimeout
            // 
            this.SessionTimeout.Interval = 1000;
            this.SessionTimeout.Tick += new System.EventHandler(this.SessionTimeout_Tick);
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 879);
            this.Controls.Add(this.pnlTransfer);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.btnBackToMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.Click += new System.EventHandler(this.frmTransfer_Click);
            this.pnlOnScreenKeypad.ResumeLayout(false);
            this.pnlTransfer.ResumeLayout(false);
            this.pnlTransfer.PerformLayout();
            this.grpTransfer.ResumeLayout(false);
            this.grpTransfer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTransferPayee;
        private ePOSOne.btnProduct.Button_WOC1 btnTransferFunds;
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
        private System.Windows.Forms.TextBox txtCashInput;
        private System.Windows.Forms.Label lblAmount;
        private ePOSOne.btnProduct.Button_WOC1 btnBackToMain;
        private System.Windows.Forms.ComboBox PayeeAccount;
        private System.Windows.Forms.Label lblSelectPayee;
        private ePOSOne.btnProduct.Button_WOC1 btnDot;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private ePOSOne.btnProduct.Button_WOC1 lblValid;
        private ePOSOne.btnProduct.Button_WOC1 lblInvalid;
        private ePOSOne.btnProduct.Button_WOC1 btnHelp;
        private System.Windows.Forms.Panel pnlTransfer;
        private System.Windows.Forms.GroupBox grpTransfer;
        private System.Windows.Forms.ToolTip ModernBankTooltip4;
        private System.Windows.Forms.Timer TransferTimer;
        private System.Windows.Forms.Timer SessionTimeout;
    }
}