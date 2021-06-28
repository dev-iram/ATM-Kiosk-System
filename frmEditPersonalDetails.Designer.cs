namespace ATM_Kiosk_System
{
    partial class frmEditPersonalDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditPersonalDetails));
            this.lblAccountDetails = new System.Windows.Forms.Label();
            this.lblMakeAmendments = new System.Windows.Forms.Label();
            this.grpPersonalDetails = new System.Windows.Forms.GroupBox();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSaveChanges = new ePOSOne.btnProduct.Button_WOC1();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnEditDetails = new ePOSOne.btnProduct.Button_WOC1();
            this.pnlPersonalDetails = new System.Windows.Forms.Panel();
            this.cbxBankDetails = new System.Windows.Forms.CheckBox();
            this.grpBankingDetails = new System.Windows.Forms.GroupBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnBackToMain = new ePOSOne.btnProduct.Button_WOC1();
            this.btnHelp = new ePOSOne.btnProduct.Button_WOC1();
            this.ModernBankTooltip3 = new System.Windows.Forms.ToolTip(this.components);
            this.DetailsTimer = new System.Windows.Forms.Timer(this.components);
            this.SessionTimeout = new System.Windows.Forms.Timer(this.components);
            this.grpPersonalDetails.SuspendLayout();
            this.pnlPersonalDetails.SuspendLayout();
            this.grpBankingDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccountDetails
            // 
            this.lblAccountDetails.AutoSize = true;
            this.lblAccountDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountDetails.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAccountDetails.Location = new System.Drawing.Point(446, 18);
            this.lblAccountDetails.Name = "lblAccountDetails";
            this.lblAccountDetails.Size = new System.Drawing.Size(293, 44);
            this.lblAccountDetails.TabIndex = 22;
            this.lblAccountDetails.Text = "Personal Details";
            // 
            // lblMakeAmendments
            // 
            this.lblMakeAmendments.AutoSize = true;
            this.lblMakeAmendments.BackColor = System.Drawing.Color.Transparent;
            this.lblMakeAmendments.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblMakeAmendments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMakeAmendments.Location = new System.Drawing.Point(412, 62);
            this.lblMakeAmendments.Name = "lblMakeAmendments";
            this.lblMakeAmendments.Size = new System.Drawing.Size(356, 29);
            this.lblMakeAmendments.TabIndex = 23;
            this.lblMakeAmendments.Text = "Make amendments as required";
            // 
            // grpPersonalDetails
            // 
            this.grpPersonalDetails.Controls.Add(this.cmbCounty);
            this.grpPersonalDetails.Controls.Add(this.txtPostcode);
            this.grpPersonalDetails.Controls.Add(this.txtCity);
            this.grpPersonalDetails.Controls.Add(this.lblPostcode);
            this.grpPersonalDetails.Controls.Add(this.lblCounty);
            this.grpPersonalDetails.Controls.Add(this.lblCity);
            this.grpPersonalDetails.Controls.Add(this.dtpDateOfBirth);
            this.grpPersonalDetails.Controls.Add(this.lblDateOfBirth);
            this.grpPersonalDetails.Controls.Add(this.txtLastName);
            this.grpPersonalDetails.Controls.Add(this.lblLastName);
            this.grpPersonalDetails.Controls.Add(this.btnSaveChanges);
            this.grpPersonalDetails.Controls.Add(this.lblFirstName);
            this.grpPersonalDetails.Controls.Add(this.lblPhoneNumber);
            this.grpPersonalDetails.Controls.Add(this.txtFullName);
            this.grpPersonalDetails.Controls.Add(this.txtPhoneNumber);
            this.grpPersonalDetails.Controls.Add(this.lblEmailAddress);
            this.grpPersonalDetails.Controls.Add(this.txtAddress);
            this.grpPersonalDetails.Controls.Add(this.txtEmailAddress);
            this.grpPersonalDetails.Controls.Add(this.lblAddress);
            this.grpPersonalDetails.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.grpPersonalDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpPersonalDetails.Location = new System.Drawing.Point(29, 111);
            this.grpPersonalDetails.Name = "grpPersonalDetails";
            this.grpPersonalDetails.Size = new System.Drawing.Size(1111, 626);
            this.grpPersonalDetails.TabIndex = 24;
            this.grpPersonalDetails.TabStop = false;
            this.grpPersonalDetails.Text = "Personal Details";
            // 
            // cmbCounty
            // 
            this.cmbCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCounty.Enabled = false;
            this.cmbCounty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCounty.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Italic);
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cmbCounty.Location = new System.Drawing.Point(632, 382);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(321, 48);
            this.cmbCounty.TabIndex = 8;
            this.ModernBankTooltip3.SetToolTip(this.cmbCounty, "Registered County of Residence");
            this.cmbCounty.SelectedIndexChanged += new System.EventHandler(this.cmbCounty_SelectedIndexChanged);
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Italic);
            this.txtPostcode.Location = new System.Drawing.Point(632, 477);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.ReadOnly = true;
            this.txtPostcode.Size = new System.Drawing.Size(321, 47);
            this.txtPostcode.TabIndex = 9;
            this.ModernBankTooltip3.SetToolTip(this.txtPostcode, "Registered Postcode");
            this.txtPostcode.TextChanged += new System.EventHandler(this.txtPostcode_TextChanged);
            this.txtPostcode.Enter += new System.EventHandler(this.txtPostcode_Enter);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Italic);
            this.txtCity.Location = new System.Drawing.Point(632, 289);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(321, 47);
            this.txtCity.TabIndex = 7;
            this.ModernBankTooltip3.SetToolTip(this.txtCity, "Registered City of Residence");
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            this.txtCity.Enter += new System.EventHandler(this.txtCity_Enter);
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPostcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPostcode.Location = new System.Drawing.Point(743, 445);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(116, 29);
            this.lblPostcode.TabIndex = 76;
            this.lblPostcode.Text = "Postcode";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCounty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCounty.Location = new System.Drawing.Point(741, 350);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(93, 29);
            this.lblCounty.TabIndex = 75;
            this.lblCounty.Text = "County";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCity.Location = new System.Drawing.Point(767, 257);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 29);
            this.lblCity.TabIndex = 74;
            this.lblCity.Text = "City";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarFont = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Enabled = false;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(632, 89);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(321, 43);
            this.dtpDateOfBirth.TabIndex = 3;
            this.ModernBankTooltip3.SetToolTip(this.dtpDateOfBirth, "Registered Date of Birth");
            this.dtpDateOfBirth.ValueChanged += new System.EventHandler(this.dtpDateOfBirth_ValueChanged);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblDateOfBirth.Location = new System.Drawing.Point(705, 57);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(154, 29);
            this.lblDateOfBirth.TabIndex = 72;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Italic);
            this.txtLastName.Location = new System.Drawing.Point(381, 89);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(223, 47);
            this.txtLastName.TabIndex = 2;
            this.ModernBankTooltip3.SetToolTip(this.txtLastName, "Registered Last Name");
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.Enter += new System.EventHandler(this.txtLastName_Enter);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLastName.Location = new System.Drawing.Point(423, 57);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(130, 29);
            this.lblLastName.TabIndex = 70;
            this.lblLastName.Text = "Last Name";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveChanges.ButtonColor = System.Drawing.Color.White;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.Location = new System.Drawing.Point(418, 540);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveChanges.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveChanges.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveChanges.Size = new System.Drawing.Size(248, 76);
            this.btnSaveChanges.TabIndex = 11;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip3.SetToolTip(this.btnSaveChanges, "Save Changes. Unsaved changes will be lost.");
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblFirstName.Location = new System.Drawing.Point(178, 57);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(132, 29);
            this.lblFirstName.TabIndex = 62;
            this.lblFirstName.Text = "First Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(705, 155);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(180, 29);
            this.lblPhoneNumber.TabIndex = 65;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Italic);
            this.txtFullName.Location = new System.Drawing.Point(138, 89);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(223, 47);
            this.txtFullName.TabIndex = 1;
            this.ModernBankTooltip3.SetToolTip(this.txtFullName, "Registered First Name");
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Italic);
            this.txtPhoneNumber.Location = new System.Drawing.Point(632, 190);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(321, 47);
            this.txtPhoneNumber.TabIndex = 5;
            this.ModernBankTooltip3.SetToolTip(this.txtPhoneNumber, "Registered Phone Number (Landline or Mobile)");
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEmailAddress.Location = new System.Drawing.Point(294, 155);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(170, 29);
            this.lblEmailAddress.TabIndex = 66;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Italic);
            this.txtAddress.Location = new System.Drawing.Point(138, 289);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(466, 235);
            this.txtAddress.TabIndex = 6;
            this.ModernBankTooltip3.SetToolTip(this.txtAddress, "Registered Place of Residence");
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Italic);
            this.txtEmailAddress.Location = new System.Drawing.Point(138, 187);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(466, 47);
            this.txtEmailAddress.TabIndex = 4;
            this.ModernBankTooltip3.SetToolTip(this.txtEmailAddress, "Registered Email Address");
            this.txtEmailAddress.TextChanged += new System.EventHandler(this.txtEmailAddress_TextChanged);
            this.txtEmailAddress.Enter += new System.EventHandler(this.txtEmailAddress_Enter);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAddress.Location = new System.Drawing.Point(334, 257);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(103, 29);
            this.lblAddress.TabIndex = 64;
            this.lblAddress.Text = "Address";
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditDetails.ButtonColor = System.Drawing.Color.White;
            this.btnEditDetails.FlatAppearance.BorderSize = 0;
            this.btnEditDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEditDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEditDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDetails.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEditDetails.Location = new System.Drawing.Point(915, 30);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditDetails.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditDetails.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditDetails.Size = new System.Drawing.Size(183, 61);
            this.btnEditDetails.TabIndex = 10;
            this.btnEditDetails.Text = "Edit Details";
            this.btnEditDetails.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip3.SetToolTip(this.btnEditDetails, "Edit Personal Details");
            this.btnEditDetails.UseVisualStyleBackColor = true;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click);
            // 
            // pnlPersonalDetails
            // 
            this.pnlPersonalDetails.Controls.Add(this.cbxBankDetails);
            this.pnlPersonalDetails.Controls.Add(this.btnEditDetails);
            this.pnlPersonalDetails.Controls.Add(this.grpBankingDetails);
            this.pnlPersonalDetails.Controls.Add(this.grpPersonalDetails);
            this.pnlPersonalDetails.Controls.Add(this.lblMakeAmendments);
            this.pnlPersonalDetails.Controls.Add(this.lblAccountDetails);
            this.pnlPersonalDetails.Location = new System.Drawing.Point(2, 58);
            this.pnlPersonalDetails.Name = "pnlPersonalDetails";
            this.pnlPersonalDetails.Size = new System.Drawing.Size(1238, 990);
            this.pnlPersonalDetails.TabIndex = 30;
            this.pnlPersonalDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPersonalDetails_Paint);
            // 
            // cbxBankDetails
            // 
            this.cbxBankDetails.AutoSize = true;
            this.cbxBankDetails.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbxBankDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbxBankDetails.Location = new System.Drawing.Point(29, 765);
            this.cbxBankDetails.Name = "cbxBankDetails";
            this.cbxBankDetails.Size = new System.Drawing.Size(268, 33);
            this.cbxBankDetails.TabIndex = 83;
            this.cbxBankDetails.Text = "View Banking Details";
            this.ModernBankTooltip3.SetToolTip(this.cbxBankDetails, "Banking details are unable to be modified. Please only access in secure environme" +
        "nt");
            this.cbxBankDetails.UseVisualStyleBackColor = true;
            this.cbxBankDetails.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grpBankingDetails
            // 
            this.grpBankingDetails.Controls.Add(this.lblPin);
            this.grpBankingDetails.Controls.Add(this.lblBalance);
            this.grpBankingDetails.Controls.Add(this.lblAccountNumber);
            this.grpBankingDetails.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.grpBankingDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpBankingDetails.Location = new System.Drawing.Point(17, 804);
            this.grpBankingDetails.Name = "grpBankingDetails";
            this.grpBankingDetails.Size = new System.Drawing.Size(1123, 144);
            this.grpBankingDetails.TabIndex = 82;
            this.grpBankingDetails.TabStop = false;
            this.grpBankingDetails.Text = "Banking Details";
            this.grpBankingDetails.Visible = false;
            this.grpBankingDetails.Enter += new System.EventHandler(this.grpBankingDetails_Enter);
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Italic);
            this.lblPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPin.Location = new System.Drawing.Point(946, 64);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(87, 33);
            this.lblPin.TabIndex = 84;
            this.lblPin.Text = "<PIN>";
            this.ModernBankTooltip3.SetToolTip(this.lblPin, "Registered PIN");
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Italic);
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBalance.Location = new System.Drawing.Point(492, 64);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(144, 33);
            this.lblBalance.TabIndex = 83;
            this.lblBalance.Text = "<Balance>";
            this.ModernBankTooltip3.SetToolTip(this.lblBalance, "Current Bank Balance");
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAccountNumber.Location = new System.Drawing.Point(15, 64);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(253, 33);
            this.lblAccountNumber.TabIndex = 82;
            this.lblAccountNumber.Text = "<Account Number>";
            this.ModernBankTooltip3.SetToolTip(this.lblAccountNumber, "Registered Account Number");
            this.lblAccountNumber.Click += new System.EventHandler(this.lblAccountNumber_Click);
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
            this.btnBackToMain.Location = new System.Drawing.Point(2, 0);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackToMain.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackToMain.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBackToMain.Size = new System.Drawing.Size(52, 52);
            this.btnBackToMain.TabIndex = 12;
            this.btnBackToMain.Text = "<";
            this.btnBackToMain.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip3.SetToolTip(this.btnBackToMain, "Back to Menu");
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
            this.btnHelp.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnHelp.Location = new System.Drawing.Point(1224, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHelp.Size = new System.Drawing.Size(52, 52);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "?";
            this.btnHelp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip3.SetToolTip(this.btnHelp, "Help");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // ModernBankTooltip3
            // 
            this.ModernBankTooltip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModernBankTooltip3.ForeColor = System.Drawing.Color.White;
            this.ModernBankTooltip3.OwnerDraw = true;
            this.ModernBankTooltip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ModernBankTooltip3.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.ModernBankTooltip3_Draw);
            this.ModernBankTooltip3.Popup += new System.Windows.Forms.PopupEventHandler(this.ModernBankTooltip3_Popup);
            // 
            // DetailsTimer
            // 
            this.DetailsTimer.Enabled = true;
            this.DetailsTimer.Interval = 1000;
            this.DetailsTimer.Tick += new System.EventHandler(this.DetailsTimer_Tick);
            // 
            // SessionTimeout
            // 
            this.SessionTimeout.Interval = 1000;
            this.SessionTimeout.Tick += new System.EventHandler(this.SessionTimeout_Tick);
            // 
            // frmEditPersonalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 1039);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pnlPersonalDetails);
            this.Controls.Add(this.btnBackToMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditPersonalDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditPersonalDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEditPersonalDetails_Load);
            this.Click += new System.EventHandler(this.frmEditPersonalDetails_Click);
            this.grpPersonalDetails.ResumeLayout(false);
            this.grpPersonalDetails.PerformLayout();
            this.pnlPersonalDetails.ResumeLayout(false);
            this.pnlPersonalDetails.PerformLayout();
            this.grpBankingDetails.ResumeLayout(false);
            this.grpBankingDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAccountDetails;
        private System.Windows.Forms.Label lblMakeAmendments;
        private System.Windows.Forms.GroupBox grpPersonalDetails;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblAddress;
        private ePOSOne.btnProduct.Button_WOC1 btnSaveChanges;
        private ePOSOne.btnProduct.Button_WOC1 btnBackToMain;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostcode;
        private ePOSOne.btnProduct.Button_WOC1 btnEditDetails;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.Panel pnlPersonalDetails;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.GroupBox grpBankingDetails;
        private System.Windows.Forms.CheckBox cbxBankDetails;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPin;
        private ePOSOne.btnProduct.Button_WOC1 btnHelp;
        private System.Windows.Forms.ToolTip ModernBankTooltip3;
        private System.Windows.Forms.Timer DetailsTimer;
        private System.Windows.Forms.Timer SessionTimeout;
    }
}