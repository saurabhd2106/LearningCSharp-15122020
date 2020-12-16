using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day2.BankAccountApp
{
    public class BankAccount
    {
        public string Number { get; set; }

        public string Owner { get; set; }

        public decimal Balance { get
            {
                decimal balance = 0;
                foreach(var transaction in allTransactions)
                {
                    balance += transaction.Amount;
                }

                return balance;
            }
        }

        private static long bankaccountNumberSeries = 2310000000;

        List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialDeposit)
        {
            this.Owner = name;

            MakeDeposit(initialDeposit, DateTime.Now, "Initial Deposit");

            this.Number = bankaccountNumberSeries.ToString();

            bankaccountNumberSeries++;
        }

        public void MakeDeposit(decimal amount, DateTime dateTime, string comments)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Deposit must be positive");
            }

            var deposit = new Transaction(amount, dateTime, comments);
            allTransactions.Add(deposit);

        }

        public void MakeWithdrawal(decimal amount, DateTime dateTime, string comments)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds..");
            }

            var withrawal = new Transaction(-amount, dateTime, comments);
            allTransactions.Add(withrawal);

        }

        public string GetTransactionHistory()
        {
            var report = new StringBuilder();

            foreach(var transaction in allTransactions)
            {
                report.Append($"{transaction.Date} : a transaction was done of amount {transaction.Amount} with comments {transaction.Comments}\n");
            }


            return report.ToString();


        }
    }
}
