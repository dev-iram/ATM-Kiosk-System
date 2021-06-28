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
    public partial class frmMainSystem : Form
    {
        int MainTimer = 60;
        int SessionTmer = 30;
        static int DefaultTimer = 60;


        public ATMconnector myATMconnector;


        public BankAccount myLoggedinBankAcount;

        public frmMainSystem()
        {
            InitializeComponent();
        }

        private void MainSystem_Load(object sender, EventArgs e)
        {
            MenuTimer.Enabled = true;
            SessionTimeout.Enabled = false;
            //Maximise the screen
            this.WindowState = FormWindowState.Maximized;
            lblWelcome.Text = "Welcome back, " + myLoggedinBankAcount.firstname + "!";

            //Set Panel to Center of Screen - Fullscreen centered
            // pnlMaintenanceSuite.Left = (this.ClientSize.Width - pnlMaintenanceSuite.Size.Width) / 2;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_WOC11_Click(object sender, EventArgs e)
        {

            MenuTimer.Enabled = false;
            this.Hide();
            frmWithdrawl PinChangeForm = new frmWithdrawl(myLoggedinBankAcount);
            //PinChangeForm.myLoggedinBankAcount = myLoggedinBankAcount;
            PinChangeForm.myATMconnector = myATMconnector;
            PinChangeForm.ShowDialog();
            ResetTimer();
            this.Close();
            this.Dispose();
            GC.Collect();

            


        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            MenuTimer.Enabled = false;
            this.Hide();
            frmCheckBalance CheckBalanceForm = new frmCheckBalance();
            CheckBalanceForm.myLoggedinBankAcount = myLoggedinBankAcount;
            CheckBalanceForm.myATMconnector = myATMconnector;
            CheckBalanceForm.ShowDialog();
            this.Close();
            ResetTimer();        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            MenuTimer.Enabled = false;
            this.Hide();
            frmTransactionHistory TransactionHistoryForm = new frmTransactionHistory();
            TransactionHistoryForm.myLoggedinBankAcount = myLoggedinBankAcount;
            TransactionHistoryForm.myATMconnector = myATMconnector;
            TransactionHistoryForm.ShowDialog();
            this.Close();
            ResetTimer();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            MenuTimer.Enabled = false;
            this.Hide();
            frmTransfer TransferForm = new frmTransfer();
            TransferForm.myLoggedinBankAcount = myLoggedinBankAcount;
            TransferForm.myATMconnector = myATMconnector;
            TransferForm.ShowDialog();
            this.Close();
            ResetTimer();
        }

        private void btnEditPersonalDetails_Click(object sender, EventArgs e)
        {
            MenuTimer.Enabled = false;
            this.Hide();
            frmEditPersonalDetails EditPersonalDetailsForm = new frmEditPersonalDetails();
            EditPersonalDetailsForm.myLoggedinBankAcount = myLoggedinBankAcount;
            EditPersonalDetailsForm.myATMconnector = myATMconnector;
            EditPersonalDetailsForm.ShowDialog();
            this.Close();
            ResetTimer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void lblAccountDetails_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC11_Click_1(object sender, EventArgs e)
        {

            ResetTimer();
            //this.Hide();
            //frmHelp AddPayeeForm = new frmHelp();
            //AddPayeeForm.myLoggedinBankAcount = myLoggedinBankAcount;
            //AddPayeeForm.ShowDialog();
            //this.Close();
            frmHelp Help = new frmHelp();
            Help.ShowDialog();
        }

        private void ModernBankTooltip7_Popup(object sender, PopupEventArgs e)
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

        private void ModernBankTooltip7_Draw(object sender, DrawToolTipEventArgs e) => DrawToolTip(e);

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

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            {
                MainTimer--;
                if (MainTimer <= 0)
                {
                    MenuTimer.Enabled = false;
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

        private void frmMainSystem_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }
    }
}
