using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using System.Drawing.Size;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace ATM_Kiosk_System
{
    public partial class frmLogin : Form
    {
        int MainTimer = 60;
        int SessionTmer = 30;
        static int DefaultTimer = 60;
        static string myFiletoOpen = Application.StartupPath + "\\BankData.db";

        public ATMconnector myATMconnector = new ATMconnector(myFiletoOpen);
        public BankAccount myBankAccount = new BankAccount();
        public frmLogin()
        {
            InitializeComponent();
           
        }
        

        public void ResetTimer()
        {
            MainTimer = DefaultTimer;

        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoginTimer.Enabled = true;
            SessionTimeout.Enabled = false;

            //Set Panel to Center of Screen - Fullscreen centered
            pnlLogin.Left = (this.ClientSize.Width - pnlLogin.Size.Width) / 2;

            txtAccountPin.MaxLength = 4;
            txtAccountNo.MaxLength = 8;
        }
        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            MainTimer--;
            if (MainTimer <= 0) 
            {
                LoginTimer.Enabled = false;
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txtAccountNo.Text == "")
            {
                MessageBox.Show("Sorry, you cannot leave any fields blank. Please enter valid credentials - Account Number and PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAccountNo.Focus();
                return;
            }

            bool canlogintoSystem = false;
            canlogintoSystem = myATMconnector.Login(txtAccountNo.Text, txtAccountPin.Text, myBankAccount);

            if (canlogintoSystem)
            {
                this.Hide();
                frmMainSystem myMainSystem = new frmMainSystem();
                //myMainSystem.myATMconnector = myATMconnector;
                myMainSystem.myLoggedinBankAcount = myBankAccount;
                myMainSystem.myATMconnector = myATMconnector;
                LoginTimer.Enabled = false;
                SessionTimeout.Enabled = false;
                myMainSystem.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Account and PIN credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAccountNo.Text = "";
                txtAccountPin.Text = "";
            }
        }

        private void Allbuttons (object sender, EventArgs e)
        {
            ResetTimer();
            string s = (sender as Button).Text;

            if (txtAccountNo.TextLength < 8)
            {
                txtAccountNo.Text += s;
            }
            else
            {

                if (txtAccountPin.Text.Length < 4)
                {

                    txtAccountPin.Text += s;
                }
                else
                {
                    MessageBox.Show("Sorry! Your pin should be no longer than 4 numbers.", "Account Pin: Max 4 Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txtAccountNo_MouseEnter(object sender, EventArgs e)
        {
            ResetTimer();
            txtAccountNo.Text = "";
            txtAccountPin.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetTimer();
            txtAccountNo.Text = "";
            txtAccountPin.Text = "";
        }

        private void lblAccountDetails_Click(object sender, EventArgs e)
        {
            ResetTimer();
            txtAccountNo.Text = "12345678";
            txtAccountPin.Text = "1234";
        }

        

        //ONLY ALLOWS NUMBERS TO BE ENTERED ON KEYBOARD!!
        private void txtAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ResetTimer();
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAccountPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ResetTimer();
            //ONLY ALLOWS NUMBERS TO BE ENTERED ON KEYBOARD!!
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ResetTimer();
            frmHelp Help = new frmHelp();
            Help.ShowDialog();
        }

        private void txtAccountNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModernBankTooltip1_Popup(object sender, PopupEventArgs e)
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

        private void ModernBankTooltip1_Draw(object sender, DrawToolTipEventArgs e) => DrawToolTip(e);
       
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

        private void frmLogin_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }
    }
}