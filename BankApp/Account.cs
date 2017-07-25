using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{

    public enum TypeOfAccounts
    {
        Checkings,
        Savings,
        Loan,
        CD
    }

    /// <summary>
    /// This class describes a Bank Account
    /// </summary>
    public class Account
    {

        #region static
        private static int lastAccountNumber = 0;
        #endregion 

        #region Properties 
        /// <summary>
        /// Email address of the person holding account
        /// </summary>
        public string EmailAddress { get; set; }

        public int AccountNumber { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public TypeOfAccounts AccountType { get; set; }

        public decimal Balance { get; private set; }
        #endregion

        #region Constructors

        //default constructor

        public Account()
        {
            //lastAccountNumber = lastAccountNumber + 1;
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;
        }


        /*
        //1st way of writing overloaded constructor
        public Account(string emailAddress) : this()
        {
            EmailAddress = emailAddress;
        }

        //2nd way of writing overloaded constructor
        public Account(string emailAddress, TypeOfAccounts accountType) : this(emailAddress)
        {
            AccountType = accountType;
        }
        */

        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to deposit</param>

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        /// <summary>
        /// Withdraw money from the bank
        /// </summary>
        /// <param name="amount">Amount to withdraw</param>
        /// <returns>The new Balance</returns>
        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }

        #endregion
    }
}
