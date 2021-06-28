using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Kiosk_System
{
    public class AccountHolder
    {
        private string AccountHolderGUID;
        private string FirstName;
        private string LastName;
        private string DateOfBirth;
        private string EmailAddress;
        private string PhoneNumber;
        private string Address;
        private string City;
        private string County;
        private string Postcode;

        public string _AccountHolderGuid { get { return AccountHolderGUID; } set { AccountHolderGUID = value; } }//property
        public string firstname { get { return FirstName; } set { FirstName = value; } }//property
        public string lastname { get { return LastName; } set { LastName = value; } }//property
        public string dateofbirth { get { return DateOfBirth; } set { DateOfBirth = value; } }//property
        public string emailaddress { get { return EmailAddress; } set { EmailAddress = value; } }//property
        public string phonenumber { get { return PhoneNumber; } set { PhoneNumber = value; } }//property
        public string address { get { return Address; } set { Address = value; } }//property
        public string city { get { return City; } set { City = value; } }//property
        public string county { get { return County; } set { County = value; } }//property
        public string postcode { get { return Postcode; } set { Postcode = value; } }//property
    }
}
