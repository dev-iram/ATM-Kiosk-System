using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Kiosk_System
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            //Maximise the screen
            this.WindowState = FormWindowState.Maximized;

            //Set Panel to Center of Screen - Fullscreen centered
            pnlWelcome.Left = (this.ClientSize.Width - pnlWelcome.Size.Width) / 2;

            //keypress - any keypress will trigger event
            this.KeyDown += new KeyEventHandler(frmWelcome_KeyDown);
        }

        void frmWelcome_KeyDown(object sender, KeyEventArgs e)
        {
            this.Hide();
            frmLogin LoginForm = new frmLogin();
            LoginForm.ShowDialog();
            this.Close();
            this.Dispose();
        }


        private void frmWelcome_Click(object sender, EventArgs e)
        {
            ClickEvent();
        }
        private void ClickEvent ()
        {
            this.Hide();
            frmLogin LoginForm = new frmLogin();
            LoginForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        private void pnlWelcome_Click(object sender, EventArgs e)
        {
            ClickEvent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClickEvent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ClickEvent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ClickEvent();
        }
    }
}
