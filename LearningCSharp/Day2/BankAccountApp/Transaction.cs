using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day2.BankAccountApp
{
    public class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public string Comments { get; set; }

        public Transaction(decimal amount, DateTime date, string comments)
        {
            this.Amount = amount;
            this.Date = date;
            this.Comments = comments;
        }
    }
}
