﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = Bank.CreateAccount("test@test.com", TypeOfAccounts.Checkings, 500.01M);

            ////Setting Properties

            ////myAccount.AccountNumber = 12345;
            ////myAccount.EmailAddress = "test@test.com";
            ////myAccount.AccountType = TypeOfAccounts.Checkings;
            ////myAccount.CreatedDate = DateTime.Now;
            ////myAccount.Balance = 236549.54M;

            ////Setting Methods
            //myAccount.Deposit(500.01M);

            //Getting properties

            Console.WriteLine($"AccountNumber: {myAccount.AccountNumber}, AccountType: {myAccount.AccountType}, " +
                $"Balance: {myAccount.Balance:C}, CreatedDate: {myAccount.CreatedDate}");

            /*var myAccount2 = new Account();

            myAccount2.EmailAddress = "test2@test.com";
            myAccount2.AccountType = TypeOfAccounts.Savings;
            //myAccount2.CreatedDate = DateTime.Now;
            */

            //another way of writing is


            var myAccount2 = Bank.CreateAccount("test2@test.com", TypeOfAccounts.Savings, 0.0M);


            //var myAccount2 = new Account
            //{
            //    AccountType = TypeOfAccounts.Savings
            //};
            //myAccount2.EmailAddress = "test2@test.com";

            Console.WriteLine($"AccountNumber: {myAccount2.AccountNumber}, AccountType: {myAccount2.AccountType}, Balance: {myAccount2.Balance:C}, CreatedDate: {myAccount2.CreatedDate}");
            Console.ReadLine();








        }
    }
}
