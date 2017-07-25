using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public static class Bank
    {
        //it is temporary storage of accounts bank create
        private static List<Account> accounts = new List<Account>();
        public static string Name { get; set; }

        //Consturctor
        static Bank()
        {
            Name = "My Bank";
        }

        //Method
        public static Account CreateAccount(string emailaddress, TypeOfAccounts accountType, decimal amount = 0.0M)
        {
            var account = new Account
            {
                EmailAddress = emailaddress,
                AccountType = accountType
            };
            if (amount > 0)
            {
                account.Deposit(amount);
            }

            //adding accounts to the list 
            accounts.Add(account);
            return account;
        }
    }
}
