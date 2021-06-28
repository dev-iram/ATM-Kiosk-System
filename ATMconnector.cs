using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace ATM_Kiosk_System
{
    public class ATMconnector
    {
        public BankAccount myBankAccount;

        public bool ConnectedOrNot = false;
        public string FileFailed;
        //static string myDataSource = @"Data Source = C:\\data\\BankData.db";
        static string myDataSource = "DATA SOURCE=" + Application.StartupPath +"\\BankData.db";
        //SQL DATA CONNECTION TO THE SQLITEDATABASE USING THE SQLCONNECTION COMPONENT
        public SQLiteConnection ModernBankDBConn = new SQLiteConnection(myDataSource);
        public DataSet ModernBankDataSet = new DataSet();

        //SQL ADAPTER
        public SQLiteDataAdapter ModernBankDataAdapter = new SQLiteDataAdapter();

        //DATATABLE
        private DataTable ModernBankDataTable = new DataTable();

        public void openDB()
        {
            if (ModernBankDBConn.State != System.Data.ConnectionState.Open)
            {
                ModernBankDBConn.Open();
            }

        }

        //this method CLOSES the DB
        public void closeDB()
        {
            if (ModernBankDBConn.State == System.Data.ConnectionState.Open)
            {
                ModernBankDBConn.Close();
            }

        }


        public ATMconnector(string myDatabaseFile)
        {
            if (File.Exists(myDatabaseFile))
            {
                myDataSource += myDatabaseFile;
                ConnectedOrNot = true;
            }
            else
            {
                FileFailed = myDatabaseFile;


                
               /*MessageBox.Show("This program could not load the required database file. The database file should be " +
                "located in the path = "+ myDatabaseFile  + " Please locate the file and try again.", "WARNING - Missing File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //CLOSES THE ENTIRE PROGRAM IF THERE IS NO DATABASE FILE
                Environment.Exit(0);*/
            }
        }
        public void FetchOtherAccountHolder(BankAccount myLoggedBankUser)
        {

            // SELECT BankAccount.Guid AS OtherPersonGuid, AccountHolder.FirstName AS OtherPersonFirstName, 
           // AccountHolder.LastName AS OtherPersonLastName FROM BankAccount LEFT JOIN AccountHolder ON AccountHolder.Guid = AccountHolderGUID
           // WHERE AccountHolder.Guid = '87EAD388-0252-4A61-A160-7703EA415B7D'


            string mySQLcommandstring = @"SELECT SELECT BankAccount.Guid AS OtherPersonGuid, AccountHolder.FirstName AS OtherPersonFirstName, 
 AccountHolder.LastName AS OtherPersonLastName FROM BankAccount LEFT JOIN AccountHolder 
                ON AccountHolder.Guid = AccountHolderGUID WHERE AccountHolder.Guid <> ='" + myLoggedBankUser._AccountGUID + "' ;";
            ModernBankDataAdapter = new SQLiteDataAdapter(mySQLcommandstring, this.ModernBankDBConn);
            ModernBankDataAdapter.Fill(ModernBankDataSet, "OtherAccountHolders");

        }

        public bool Login(string LocalAccount, string LocalAccountPin, BankAccount myLoggedBankUser)
        {

            bool LoggedonOK = false;

            DataTable BankUserDT = new DataTable();

            this.openDB(); //opens the database if not already opened ! makes sure its available
            //string mySQLcommandstring = "SELECT * FROM BankAccount WHERE AccountNumber='" + LocalAccount + "' AND AccountPin='" + LocalAccountPin + "';";
            string mySQLcommandstring = "SELECT * from BankAccount  LEFT JOIN AccountHolder ON AccountHolder.Guid = " +
                "BankAccount.AccountHolderGUID WHERE AccountNumber='" + LocalAccount + "' AND AccountPin='" + LocalAccountPin + "'LIMIT 1;";

            ModernBankDataAdapter = new SQLiteDataAdapter(mySQLcommandstring, this.ModernBankDBConn);


            ModernBankDataAdapter.Fill(BankUserDT);

            //if ( ) // check if ENcrypted

            if (BankUserDT.Rows.Count > 0) {

                myLoggedBankUser.accountnumber = BankUserDT.Rows[0].ItemArray[2].ToString();
                myLoggedBankUser.accountpin = BankUserDT.Rows[0].ItemArray[3].ToString();
                myLoggedBankUser.balance = BankUserDT.Rows[0].ItemArray[4].ToString();
                myLoggedBankUser.firstname = BankUserDT.Rows[0].ItemArray[10].ToString();
                myLoggedBankUser.lastname = BankUserDT.Rows[0].ItemArray[11].ToString();
                myLoggedBankUser.dateofbirth = BankUserDT.Rows[0].ItemArray[12].ToString();
                myLoggedBankUser.emailaddress = BankUserDT.Rows[0].ItemArray[13].ToString();
                myLoggedBankUser.phonenumber = BankUserDT.Rows[0].ItemArray[14].ToString();
                myLoggedBankUser.address = BankUserDT.Rows[0].ItemArray[15].ToString();
                myLoggedBankUser.city = BankUserDT.Rows[0].ItemArray[16].ToString();
                myLoggedBankUser.county = BankUserDT.Rows[0].ItemArray[17].ToString();
                myLoggedBankUser.postcode = BankUserDT.Rows[0].ItemArray[18].ToString();
                myLoggedBankUser._AccountGUID = BankUserDT.Rows[0].ItemArray[1].ToString();
                myLoggedBankUser._AccountHolderGuid = BankUserDT.Rows[0].ItemArray[9].ToString();


                LoggedonOK = true;

            }
            return LoggedonOK;
        }


        public bool FetchCurrentPin(BankAccount myLoggedBankUser)
        {
            bool PinFetchOK = false;

            DataTable BankUserDT = new DataTable();

            string mySQLcommandstring = @"SELECT AccountPin from BankAccount 
                                        WHERE Guid ='" + myLoggedBankUser._AccountGUID + "'";

            ModernBankDataAdapter = new SQLiteDataAdapter(mySQLcommandstring, this.ModernBankDBConn);


            ModernBankDataAdapter.Fill(BankUserDT);

            //if ( ) // check if ENcrypted

            if (BankUserDT.Rows.Count > 0)
            {
                myLoggedBankUser.accountpin = BankUserDT.Rows[0].ItemArray[0].ToString();
                PinFetchOK = true;
            }

            return PinFetchOK;

        }


        public bool UpdateCurrentPin(string NEWPin, BankAccount myLoggedBankUser)
        {
            bool PinUpdateOK = false;

            DataTable BankUserDT = new DataTable();

            string mySQLcommandstring = @"UPDATE BankAccount SET AccountPin='"+ NEWPin + "' WHERE Guid ='" + myLoggedBankUser._AccountGUID + "'";

            // go look at my opther projects UPDATE!
            SQLiteCommand sqlUpdate = new SQLiteCommand(mySQLcommandstring, ModernBankDBConn);
            this.openDB();
            sqlUpdate.ExecuteNonQuery();
            MessageBox.Show("Your PIN has been updated!");

            return PinUpdateOK;

        }


        public void FetchBalance(BankAccount myLoggedBankUser)
        {
            this.openDB();
            string mySQLcommandstring = "SELECT Balance from BankAccount WHERE Guid='" + myLoggedBankUser._AccountGUID + "'"; 

             ModernBankDataAdapter = new SQLiteDataAdapter(mySQLcommandstring, this.ModernBankDBConn);

            DataTable BankUserDT = new DataTable();
            ModernBankDataAdapter.Fill(BankUserDT);

            if (BankUserDT.Rows.Count > 0)
            {

                myLoggedBankUser.balance = BankUserDT.Rows[0].ItemArray[0].ToString();
            }
        }

        public void UpdatePersonalDetails(BankAccount myLoggedBankUser)
        {

            this.openDB();

            DataTable BankUserDT = new DataTable();


            string mySQLCommandString = @"UPDATE AccountHolder SET FirstName='" + myLoggedBankUser.firstname 
                                        + "', LastName= '" + myLoggedBankUser.lastname
                                        + "', DateOfBirth ='" + myLoggedBankUser.dateofbirth 
                                        + "' , EmailAddress = '" + myLoggedBankUser.emailaddress
                                        + "', PhoneNumber ='" + myLoggedBankUser.phonenumber 
                                        + "', Address = '" + myLoggedBankUser.address
                                        + "', City ='" + myLoggedBankUser.city 
                                        + "', County ='" + myLoggedBankUser.county
                                        + "', Postcode ='" + myLoggedBankUser.postcode 
                                        + "' WHERE Guid='" + myLoggedBankUser._AccountHolderGuid + "';";

            SQLiteCommand sqlUpdatePersonalDetails = new SQLiteCommand(mySQLCommandString, ModernBankDBConn);


            sqlUpdatePersonalDetails.ExecuteNonQuery();
            MessageBox.Show("Your Personal Details have been updated!");
          
        }

        public void TransferTransaction(string TransferToAccountGuid, double BalanceTransfer, string TransferDescription, BankAccount myLoggedBankUser)

        {
            double DebitBalance = 0;
            double CreditBalance = 0;
            DebitBalance = BalanceTransfer;

            Guid TransactionGuid = Guid.NewGuid();

            //INSERT FUNDS INPUTTED BY USER
            string mySQLCommandString = @"INSERT INTO BankTransactions (Guid,BankAccountGUID,Debit,Credit,DateOfTransaction,PayeeAccountGUID,Description) 
                                        VALUES ('"
                                     + TransactionGuid.ToString() + "','"
                                     + myLoggedBankUser._AccountGUID + "','"
                                     + DebitBalance.ToString() + "','"
                                     + CreditBalance.ToString() + "','"
                                     + DateTime.Now.ToString() + "','"
                                     + TransferToAccountGuid + "','"
                                     + TransferDescription + "')";
            this.openDB();
            SQLiteCommand sqlInsertTransaction1 = new SQLiteCommand(mySQLCommandString, ModernBankDBConn);
            sqlInsertTransaction1.ExecuteNonQuery();

           double UpdatedBalance = Convert.ToDouble(myLoggedBankUser.balance) - BalanceTransfer;
        



            //UPDATE ACCOUNT WITH NEW BALANCE
             mySQLCommandString = @"UPDATE BankAccount SET Balance = '" + UpdatedBalance.ToString()
                                        + "'" + " WHERE Guid='" + myLoggedBankUser._AccountGUID + "';";

            SQLiteCommand sqlUpdateBalance = new SQLiteCommand(mySQLCommandString, ModernBankDBConn);
            sqlUpdateBalance.ExecuteNonQuery();

            myLoggedBankUser.balance = UpdatedBalance.ToString();

            TransactionGuid = Guid.NewGuid();

            //TRANSACTION 2!! 
            DebitBalance = 0;
            CreditBalance = BalanceTransfer;


            mySQLCommandString = @"INSERT INTO BankTransactions (Guid,BankAccountGUID,Debit,Credit,DateOfTransaction,PayeeAccountGUID,Description) 
                                        VALUES ('"
                                     + TransactionGuid.ToString() + "','"
                                     + TransferToAccountGuid + "','"
                                     + DebitBalance.ToString() + "','"
                                     + CreditBalance.ToString() + "','"
                                     + DateTime.Now.ToString() + "','"
                                     + "" + "','" //CREDIT
                                     + TransferDescription + "')";
            this.openDB();
            SQLiteCommand sqlInsertTransaction2 = new SQLiteCommand(mySQLCommandString, ModernBankDBConn);
            sqlInsertTransaction2.ExecuteNonQuery();

            //MessageBox.Show("Transaction 2 ADDED!");

            //UPDATE PAYEE ACCOUNT BALANCE!!
            double PayeeAccountBalance = FetchPayeeAccountBalance(TransferToAccountGuid);
            PayeeAccountBalance = PayeeAccountBalance + BalanceTransfer;



            mySQLCommandString = @"UPDATE BankAccount SET Balance = '" + PayeeAccountBalance.ToString()
                                        + "'" + " WHERE Guid='" + TransferToAccountGuid + "';";

            SQLiteCommand sqlPayeeUpdateBalance = new SQLiteCommand(mySQLCommandString, ModernBankDBConn);
            sqlPayeeUpdateBalance.ExecuteNonQuery();
        }

        public double FetchPayeeAccountBalance(string AccountGuid)
        {
            double myBalance = 0;
            DataTable BankUserDT = new DataTable();
            string mySQLCommandString = "SELECT Balance FROM BankAccount WHERE Guid='" + AccountGuid + "' ;";
            ModernBankDataAdapter = new SQLiteDataAdapter(mySQLCommandString, this.ModernBankDBConn);
            ModernBankDataAdapter.Fill(BankUserDT);
            myBalance = Convert.ToDouble(BankUserDT.Rows[0].ItemArray[0].ToString());
            return myBalance;
        }

        public void ViewTransactionHistory(BankAccount myLoggedBankUser)
        {
            this.openDB();
            //string mySQLCommandString = "SELECT Debit, Credit, DateOfTransaction, Description, PayeeAccountGUID FROM BankTransactions WHERE BankAccountGUID ='" + myLoggedBankUser._AccountGUID + "';";
            string mySQLCommandString = "SELECT substr(DateOfTransaction,0,11) AS TransactionDate,substr(DateOfTransaction,11,14) AS TransactionTime, Debit, Credit, Description,AccountHolder.FirstName AS PayeeFirstName, AccountHolder.LastName AS PayeeLastName FROM BankTransactions LEFT JOIN BankAccount ON BankAccount.Guid = PayeeAccountGUID LEFT JOIN AccountHolder ON AccountHolder.Guid = BankAccount.AccountHolderGUID WHERE BankAccountGUID = '" + myLoggedBankUser._AccountGUID + "' ORDER BY BankTransactions.uid DESC ;";
            ModernBankDataAdapter = new SQLiteDataAdapter(mySQLCommandString, this.ModernBankDBConn);
            DataTable BankUserDT = new DataTable();
            //ModernBankDataAdapter.Fill(BankUserDT);
            //  dgvTransactions.DataSource = dtDGV;

            if (ModernBankDataSet.Tables.Contains("dgvTransactions"))
            {
                ModernBankDataSet.Tables.Remove("dgvTransactions");

            }


            ModernBankDataAdapter.Fill(ModernBankDataSet, "dgvTransactions");
        }


        //FILLSCOMBOBOX WITH DATA.
        public void TransferFromAccount(BankAccount myLoggedBankUser)
        {
            this.openDB(); //opens the database if not already opened ! makes sure its available
            string mySQLcommandstring = @"SELECT BankAccount.Guid AS OtherPersonGuid, AccountHolder.FirstName AS OtherPersonFirstName, 
            AccountHolder.LastName AS OtherPersonLastName FROM BankAccount LEFT JOIN AccountHolder 
                ON AccountHolder.Guid = AccountHolderGUID WHERE AccountHolder.Guid <> '" + myLoggedBankUser._AccountHolderGuid + "' ;";
            ModernBankDataAdapter = new SQLiteDataAdapter(mySQLcommandstring, this.ModernBankDBConn);

            if (ModernBankDataSet.Tables.Contains("OtherAccountHolders"))
            {
                ModernBankDataSet.Tables.Remove("OtherAccountHolders");

            }

            ModernBankDataAdapter.Fill(ModernBankDataSet, "OtherAccountHolders");
        }
    }
}
