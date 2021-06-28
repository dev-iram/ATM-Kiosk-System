using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Drawing2D;
using System.Drawing.Text;


namespace ATM_Kiosk_System
{
    public partial class frmEditPersonalDetails : Form
    {
        int MainTimer = 60;
        int SessionTmer = 30;
        static int DefaultTimer = 60;
        //static string myFiletoOpen = Application.StartupPath + "\\BankData.db";

        public ATMconnector myATMconnector;
        public BankAccount myLoggedinBankAcount;

        public frmEditPersonalDetails()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {

            DetailsTimer.Enabled = false;
            SessionTimeout.Enabled = false;
            this.Hide();
            frmMainSystem myMainSystem = new frmMainSystem();
            myMainSystem.myLoggedinBankAcount = myLoggedinBankAcount;
            myMainSystem.myATMconnector = myATMconnector;
            myMainSystem.ShowDialog();
            this.Close();
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            ResetTimer();
            txtFullName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            dtpDateOfBirth.Enabled = true;
            txtEmailAddress.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCity.ReadOnly = false;
            cmbCounty.Enabled = true;
            txtPostcode.ReadOnly = false;
            btnEditDetails.Visible = false;
            btnSaveChanges.Visible = true;
        }

        private void frmEditPersonalDetails_Load(object sender, EventArgs e)
        {
            DetailsTimer.Enabled = true;
            SessionTimeout.Enabled = false;

            txtFullName.Text = myLoggedinBankAcount.firstname;
            txtLastName.Text = myLoggedinBankAcount.lastname;
            dtpDateOfBirth.Text = myLoggedinBankAcount.dateofbirth;
            txtEmailAddress.Text = myLoggedinBankAcount.emailaddress;
            txtPhoneNumber.Text = myLoggedinBankAcount.phonenumber;
            txtAddress.Text = myLoggedinBankAcount.address;
            txtCity.Text = myLoggedinBankAcount.city;
            cmbCounty.Text = myLoggedinBankAcount.county; 
            txtPostcode.Text = myLoggedinBankAcount.postcode;
            lblAccountNumber.Text = "Account Number: " + myLoggedinBankAcount.accountnumber;
            lblBalance.Text = "Balance: " + "€" + myLoggedinBankAcount.balance;
            lblPin.Text = "Pin: " + myLoggedinBankAcount.accountpin;

            //Set Panel to Center of Screen - Fullscreen centered
            pnlPersonalDetails.Left = (this.ClientSize.Width - grpPersonalDetails.Size.Width) / 2;

            //display details on load
           // myATMconnector.FetchPersonalDetails(txtFullName.Text, txtLastName.Text, dtpDateOfBirth.Value, txtEmailAddress.Text,
        //    txtPhoneNumber.Text, txtAddress.Text, txtCity.Text, cmbCounty.Items, txtPostcode.Text, myLoggedinBankAcount);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ResetTimer();

            string warningErrorMessage = "";
            //1. FULL NAME
            if (txtFullName.Text == "")
            {
               warningErrorMessage += "You must enter a First Name" + Environment.NewLine;
                txtFullName.BackColor = System.Drawing.ColorTranslator.FromHtml("#ccccff");
            }

            //2. PASSPORT NUMBER
            if (txtLastName.Text == "")
            {
                
                warningErrorMessage += "You must enter a Last Name" + Environment.NewLine;
                txtLastName.BackColor = System.Drawing.ColorTranslator.FromHtml("#ccccff");
            }

            //4. PHONE NUMBER
            if (txtEmailAddress.Text == "")
            {
               
                warningErrorMessage += "You must enter an Email Address" + Environment.NewLine;
                txtEmailAddress.BackColor = System.Drawing.ColorTranslator.FromHtml("#ccccff");
            }

            //5. EMAIL ADDRESS
            if (txtPhoneNumber.Text == "")
            {
              
                warningErrorMessage += "You must enter a Phone Number" + Environment.NewLine;
                txtPhoneNumber.BackColor = System.Drawing.ColorTranslator.FromHtml("#ccccff");
            }

            //6. GENDER
            if (txtAddress.Text == "")
            {
             
                warningErrorMessage += "You must enter an Address" + Environment.NewLine;
                txtAddress.BackColor = System.Drawing.ColorTranslator.FromHtml("#ccccff");
            }
            //6. GENDER
            if (txtCity.Text == "")
            {
               warningErrorMessage += "You must enter a City" + Environment.NewLine;
                txtCity.BackColor = System.Drawing.ColorTranslator.FromHtml("#ccccff");
            }
            //6. GENDER
            if (cmbCounty.Text == "")
            {
               
                warningErrorMessage += "You must enter a County" + Environment.NewLine;
                cmbCounty.BackColor = System.Drawing.ColorTranslator.FromHtml("#ccccff");
            }
            //6. GENDER
            if (txtPostcode.Text == "")
            {
              
  
                warningErrorMessage += "You must enter a county";
                txtPostcode.BackColor = System.Drawing.ColorTranslator.FromHtml("#ccccff");
            }



            if (warningErrorMessage !="")
            {
                MessageBox.Show("Sorry, fields cannot be set as blank." + "\n" + ""  + warningErrorMessage);
               return;
            }
            else
            {
                myLoggedinBankAcount.firstname = txtFullName.Text;
                myLoggedinBankAcount.lastname = txtLastName.Text;
                myLoggedinBankAcount.dateofbirth = dtpDateOfBirth.Text;
                myLoggedinBankAcount.emailaddress = txtEmailAddress.Text;
                myLoggedinBankAcount.phonenumber = txtPhoneNumber.Text;
                myLoggedinBankAcount.address = txtAddress.Text;
                myLoggedinBankAcount.city = txtCity.Text;
                myLoggedinBankAcount.county = cmbCounty.Text;
                myLoggedinBankAcount.postcode = txtPostcode.Text;

                myATMconnector.UpdatePersonalDetails(myLoggedinBankAcount);
                
                btnEditDetails.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ResetTimer();
            if (cbxBankDetails.Checked == true)
            {
                grpBankingDetails.Visible = true;
            }
            else
            {
                grpBankingDetails.Visible = false;
            }
        }

        private void lblAccountNumber_Click(object sender, EventArgs e)
        {

        }

        private void grpBankingDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ResetTimer();
            frmHelp Help = new frmHelp();
            Help.ShowDialog();
        }


        private void ModernBankTooltip3_Popup(object sender, PopupEventArgs e)
        {

            ToolTip tt = (sender as ToolTip);
            string toolTipText = tt.GetToolTip(e.AssociatedControl);
            TextFormatFlags flags = TextFormatFlags.LeftAndRightPadding | TextFormatFlags.NoClipping |
                                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            using (Font font = new Font("Montserrat", 13.0f, FontStyle.Italic))
            {
                Size textSize = TextRenderer.MeasureText(toolTipText, font, Size.Empty, flags);
                e.ToolTipSize = Size.Add(textSize, new Size(2, 2));
            }
        }

        private void ModernBankTooltip3_Draw(object sender, DrawToolTipEventArgs e) => DrawToolTip(e);

        private void DrawToolTip(DrawToolTipEventArgs e)
        {
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            using (var sf = new StringFormat(StringFormatFlags.NoClip | StringFormatFlags.NoWrap))
            {
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
                Rectangle shadowBounds = new Rectangle(new Point(e.Bounds.X + 1, e.Bounds.Y + 1), e.Bounds.Size);
                using (var linearGradientBrush = new LinearGradientBrush(e.Bounds, System.Drawing.ColorTranslator.FromHtml("#8080FF"), System.Drawing.ColorTranslator.FromHtml("#8080FF"), 30f))
                using (Font font = new Font("Montserrat", 12.0f, FontStyle.Italic))
                {
                    e.Graphics.FillRectangle(linearGradientBrush, e.Bounds);
                    e.Graphics.DrawString(e.ToolTipText, font, Brushes.Black, shadowBounds, sf);
                    e.Graphics.DrawString(e.ToolTipText, font, Brushes.White, e.Bounds, sf);
                }
            }
        }

        private void pnlPersonalDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DetailsTimer_Tick(object sender, EventArgs e)
        {
            MainTimer--;
            if (MainTimer <= 0)
            {
                DetailsTimer.Enabled = false;
                if (MessageBox.Show("Your session is about to be timed out." + "\n" + "Do you need more time?", "Session Timeout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SessionTimeout.Enabled = true;
                }
                else
                {
                    System.Windows.Forms.Application.Exit();
                }

            }
        }

        private void SessionTimeout_Tick(object sender, EventArgs e)
        {
            SessionTmer--;
            if (SessionTmer <= 0)
            {
                SessionTimeout.Enabled = false;
                MessageBox.Show("Uh oh! Looks like your session has timed out and we need you to log in again.", "Session Timeout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void ResetTimer()
        {
            MainTimer = DefaultTimer;

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void cmbCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void txtPostcode_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void frmEditPersonalDetails_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            txtFullName.BackColor = System.Drawing.Color.White;
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            txtLastName.BackColor = System.Drawing.Color.White;
        }

        private void txtEmailAddress_Enter(object sender, EventArgs e)
        {
            txtEmailAddress.BackColor = System.Drawing.Color.White;
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            txtAddress.BackColor = System.Drawing.Color.White;
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            txtPhoneNumber.BackColor = System.Drawing.Color.White;
        }

        private void txtCity_Enter(object sender, EventArgs e)
        {
            txtCity.BackColor = System.Drawing.Color.White;
        }

        private void txtPostcode_Enter(object sender, EventArgs e)
        {
            txtPostcode.BackColor = System.Drawing.Color.White;
        }
    }
}
