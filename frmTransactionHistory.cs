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
     public partial class frmTransactionHistory : Form
    {
        int MainTimer = 60;
        int SessionTmer = 30;
        static int DefaultTimer = 60;
        public ATMconnector myATMconnector;

        public BankAccount myLoggedinBankAcount;
        public frmTransactionHistory()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            TransactionTimer.Enabled = false;
            SessionTimeout.Enabled = false;
            this.Hide();
            frmMainSystem myMainSystem = new frmMainSystem();
            myMainSystem.myLoggedinBankAcount = myLoggedinBankAcount;
            myMainSystem.myATMconnector = myATMconnector;
            myMainSystem.ShowDialog();
            this.Close();
        }

        public void frmTransactionHistory_Load(object sender, EventArgs e)
        {
            TransactionTimer.Enabled = true;
            SessionTimeout.Enabled = false;

            myATMconnector.ViewTransactionHistory(myLoggedinBankAcount);
            //dgvTransactions.DataSource = myLoggedinBankAcount;
            dgvTransactions.DataSource = myATMconnector.ModernBankDataSet.Tables["dgvTransactions"];

            this.dgvTransactions.DefaultCellStyle.Font = new Font("Montserrat", 10);
            this.dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ResetTimer();
            frmHelp Help = new frmHelp();
            Help.ShowDialog();
        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModernBankTooltip5_Popup(object sender, PopupEventArgs e)
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

        private void ModernBankTooltip5_Draw(object sender, DrawToolTipEventArgs e) => DrawToolTip(e);

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

        private void TransactionTimer_Tick(object sender, EventArgs e)
        {
            MainTimer--;
            if (MainTimer <= 0)
            {
                TransactionTimer.Enabled = false;
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

        private void frmTransactionHistory_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetTimer();
        }
    }
}
