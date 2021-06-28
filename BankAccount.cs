using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Kiosk_System
{
    public class BankAccount : AccountHolder
    {
        private string AccountNumber;
        private string AccountPin;
        private string Balance;
        private string myAccountGUID;
       // private string AccountHolderGUID;
       // private string AccountTypeGUID;

        public string accountnumber { get { return AccountNumber; } set { AccountNumber = value; } }//property
        public string accountpin { get { return AccountPin; } set { AccountPin = value; } }//property
        public string balance { get { return Balance; } set { Balance = value; } }//property
        public string _AccountGUID { get { return myAccountGUID; } set { myAccountGUID = value; } }//property

    }
}
