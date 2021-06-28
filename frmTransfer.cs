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
    public partial class frmTransfer : Form
    {
        int MainTimer = 60;
        int SessionTmer = 30;
        static int DefaultTimer = 60;

        public ATMconnector myATMconnector;

        public BankAccount myLoggedinBankAcount;
        public frmTransfer()
        {
            InitializeComponent();
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {

            TransferTimer.Enabled = true;
            SessionTimeout.Enabled = false;

            pnlTransfer.Left = (this.ClientSize.Width - pnlTransfer.Size.Width) / 2;

            PayeeAccount.Text = "";

            myATMconnector.TransferFromAccount(myLoggedinBankAcount);
            

            lblAccountNumber.Text = "Account Number: " + myLoggedinBankAcount.accountnumber;
            lblBalance.Text = "Balance: " + "€" + myLoggedinBankAcount.balance;

        

        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            TransferTimer.Enabled = false;
            SessionTimeout.Enabled = false;
            this.Hide();
            frmMainSystem myMainSystem = new frmMainSystem();
            myMainSystem.myLoggedinBankAcount = myLoggedinBankAcount;
            myMainSystem.myATMconnector = myATMconnector;
            myMainSystem.ShowDialog();
            this.Close();
        }

        private void AllButtons(object sender, EventArgs e)
        {
            ResetTimer();
            string s = (sender as Button).Text;

            if (txtCashInput.TextLength < 8)
            {
                //txtInput.Text = "€";
                txtCashInput.Text +=s;
            }
           
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
         //   txtCashInput.Text =+ ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetTimer();
            txtCashInput.Text = "";
            txtDescription.Text = "";
            PayeeAccount.Text = "";
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ONLY ALLOWS NUMBERS TO BE ENTERED ON KEYBOARD!!
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             if (txtCashInput.Text =="")
            {
                MessageBox.Show("Sorry you must enter a value to transfer!", "Error: No value to transfer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblInvalid.Visible = true;
                lblValid.Visible = false;
                return;


            }

            else if (txtDescription.Text == "")
            {
                MessageBox.Show("Sorry you must enter a description for the transfer! ", "Error: No description", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            else if (PayeeAccount.Text == "")
            {
                MessageBox.Show("Sorry you must select a payee! ", "Error: No payee selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            else
            {
                lblValid.Visible = true;
                lblInvalid.Visible = false;
            } 
             if (   (Convert.ToDouble(txtCashInput.Text) > Convert.ToDouble(myLoggedinBankAcount.balance)  ) )
                {
                MessageBox.Show("Sorry, you do not have" + txtCashInput.Text + "in your account to make this transaction", "Error: Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblValid.Visible = false;
                txtCashInput.Text = "";
                return;    
            }

     
                myATMconnector.TransferTransaction(PayeeAccount.SelectedValue.ToString(), Convert.ToDouble(txtCashInput.Text), txtDescription.Text, myLoggedinBankAcount);
            //MessageBox.Show("Your transfer was successful!");
            lblBalance.Text = "Balance: " + "€" + myLoggedinBankAcount.balance;


            if (MessageBox.Show("Your transfer was successful!" + "\n" + "Would you like to make another transfer?", "Transfer Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtCashInput.Text = "";
                txtDescription.Text = "";
                PayeeAccount.SelectedValue = "";
                lblValid.Visible = false;
                lblInvalid.Visible = false;
            }

            else

            {
                TransferTimer.Enabled = false;
                SessionTimeout.Enabled = false;
                this.Hide();
                frmMainSystem myMainSystem = new frmMainSystem();
                myMainSystem.myLoggedinBankAcount = myLoggedinBankAcount;
                myMainSystem.myATMconnector = myATMconnector;
                myMainSystem.ShowDialog();
                this.Close();

            }


        }

        private void PayeeAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ResetTimer();
            frmHelp Help = new frmHelp();
            Help.ShowDialog();
        }

        private void PayeeAccount_Click(object sender, EventArgs e)
        {
            PayeeAccount.DataSource = myATMconnector.ModernBankDataSet.Tables["OtherAccountHolders"];
            PayeeAccount.DisplayMember = "OtherPersonFirstName";
            PayeeAccount.ValueMember = "OtherPersonGuid";
        }

        private void pnlTransfer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ModernBankTooltip4_Popup(object sender, PopupEventArgs e)
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

        private void ModernBankTooltip4_Draw(object sender, DrawToolTipEventArgs e) => DrawToolTip(e);

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

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                // These characters may pass
                e.Handled = false;
            }
            else
            {
                // Everything that is not a letter, nor a backspace nor a space will be blocked
                e.Handled = true;
            }
        }

        private void TransferTimer_Tick(object sender, EventArgs e)
        {
            MainTimer--;
            if (MainTimer <= 0)
            {
                TransferTimer.Enabled = false;
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

        private void frmTransfer_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }
    }
}
