using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
    public partial class frmWithdrawl : Form
    {

        int MainTimer = 60;
        int SessionTmer = 30;
        static int DefaultTimer = 60;

        public ATMconnector myATMconnector;

        public BankAccount myLoggedinBankAcount;

        public frmWithdrawl(BankAccount myPassedoverinBankAcount)
        {
            InitializeComponent();
            myLoggedinBankAcount = myPassedoverinBankAcount;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            ChangePinTimer.Enabled = false;
            SessionTimeout.Enabled = false;
            this.Hide();
            frmMainSystem myMainSystem = new frmMainSystem();
            myMainSystem.myLoggedinBankAcount = myLoggedinBankAcount;
            myMainSystem.myATMconnector = myATMconnector;
            myMainSystem.ShowDialog();
            this.Close();
            this.Dispose();
            GC.Collect();
        }

        private void frmWithdrawl_Load(object sender, EventArgs e)
        {

            ChangePinTimer.Enabled = true;
            SessionTimeout.Enabled = false;

            //Set Panel to Center of Screen - Fullscreen centered
            pnlChangePin.Left = (this.ClientSize.Width - pnlChangePin.Size.Width) / 2;

            myATMconnector.FetchCurrentPin(myLoggedinBankAcount);

            txtCurrentPin.MaxLength = 4;
            txtNewPin.MaxLength = 4;
            txtNewPinConfirm.MaxLength = 4;
                    }

        private void Allbuttons(object sender, EventArgs e)
        {
            ResetTimer();
            string s = (sender as Button).Text;

            if (txtCurrentPin.TextLength < 4)
            {
                txtCurrentPin.Text += s;
            }
            


            if (grpNewPIN.Visible)
            {
                if (txtNewPin.Text.Length < 4)
                {
                    txtNewPin.Text += s;

                    if (txtNewPin.Text.Length > 3) { 
                        lblValidPin1.Visible = true;
                        txtNewPinConfirm.Enabled = true;
                    }

                }
                else
                {
                    

                    if (txtNewPinConfirm.Text.Length < 4)
                    {
                        
                       
                        txtNewPinConfirm.Text += s;

                        if (txtNewPinConfirm.Text.Length > 3)
                        {
                            lblValidPin2.Visible = true;
                            lblInvalidPin2.Visible = false;
                            btnPinChangeNow.Visible = true;

                            

                        }

                    }
                    if (txtNewPinConfirm.Text != txtNewPin.Text)
                    {
                        lblInvalidPin2.Visible = true;
                        btnPinChangeNow.Visible = false;
                    }
                    if (txtNewPin.Text != txtNewPinConfirm.Text)
                    {
                        lblInvalidPin2.Visible = true;
                        btnPinChangeNow.Visible = false;
                    }
                    if (txtNewPin.Text == txtNewPinConfirm.Text)
                    {
                        lblInvalidPin2.Visible = false;
                        btnPinChangeNow.Visible = true;
                        lblValidPin1.Visible = true;
                        lblValidPin2.Visible = true;
                    }
                }
            }
        }



        private void lblValid_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckCurrentPin_Click(object sender, EventArgs e)
        {
            //bool CorrectPinEntered = false;

            ResetTimer();
            if (txtCurrentPin.Text == myLoggedinBankAcount.accountpin)
            {
                lblValid.Visible = true;
                lblInvalid.Visible = false;
                btnCheckCurrentPin.Visible = false;
                btnCheckCurrentPin.Visible = false;
                grpNewPIN.Visible = true;
                txtCurrentPin.Enabled = false;
                lblValidPin2.Visible = false;
            }
            else
            {

                MessageBox.Show("Sorry your pin is incorrect. Please try again.");
                lblInvalid.Visible = true;
                lblValid.Visible = false;
                btnCheckCurrentPin.Visible = true;
                txtCurrentPin.Text = "";
            }


            if (btnCheckCurrentPin.Visible == true)
                {
                lblInvalidPin2.Visible = false;
                lblValidPin2.Visible = true;

            }
        }

        private void btnPinChangeNow_Click(object sender, EventArgs e)
        {
            ResetTimer();// if (txtNewPin.Text == txtNewPinConfirm.Text)
            if (lblValidPin2.Visible == true)
            {
                
                myATMconnector.UpdateCurrentPin(txtNewPin.Text, myLoggedinBankAcount);
                myLoggedinBankAcount.accountpin = txtNewPin.Text;

                this.Hide();
                frmMainSystem myMainSystem = new frmMainSystem();
                myMainSystem.myLoggedinBankAcount = myLoggedinBankAcount;
                myMainSystem.myATMconnector = myATMconnector;
                myMainSystem.ShowDialog();
                this.Close();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            if (lblValid.Visible == true)
            {
                txtNewPin.Text = "";
                txtNewPinConfirm.Text = "";
                lblValidPin1.Visible = false;
                lblValidPin2.Visible = false;
                lblInvalidPin1.Visible = false;
                lblInvalidPin2.Visible = false;

            }
            else
            {
                txtCurrentPin.Text = "";
                txtNewPin.Text = "";
                txtNewPinConfirm.Text = "";
            }
        }

        private void txtCurrentPin_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void txtCurrentPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY ALLOWS NUMBERS TO BE ENTERED ON KEYBOARD!!
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtNewPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY ALLOWS NUMBERS TO BE ENTERED ON KEYBOARD!!
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtNewPinConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY ALLOWS NUMBERS TO BE ENTERED ON KEYBOARD!!
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ResetTimer();
            frmHelp Help = new frmHelp();
            Help.ShowDialog();
        }




       

       // private void ModernBankTooltip2_Draw(object sender, DrawToolTipEventArgs e) => DrawToolTip(e);

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

        private void ModernBankTooltip2_Draw_1(object sender, DrawToolTipEventArgs e) => DrawToolTip(e);

        private void ModernBankTooltip2_Popup(object sender, PopupEventArgs e)
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

        private void ChangePinTimer_Tick(object sender, EventArgs e)
        {
            MainTimer--;
            if (MainTimer <= 0)
            {
                ChangePinTimer.Enabled = false;
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

        private void txtNewPin_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void txtNewPinConfirm_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void frmWithdrawl_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void pnlChangePin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
