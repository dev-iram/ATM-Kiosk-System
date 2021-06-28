using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace ATM_Kiosk_System
{
    public partial class frmHelp : Form
    {
        public ATMconnector myATMconnector = new ATMconnector("");
        public BankAccount myLoggedinBankAcount;
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmAddPayee_Load(object sender, EventArgs e)
        {
            //RELATIVE URL - CONNECTS THE URL TO THE FOLDER ! in debug/bin/help system/index.html
            string appDir = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().GetName().CodeBase);
            webBrowser1.Url = new Uri(Path.Combine(appDir, @"Help System\index.html"));



        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
