using LearningCSharp.Day2.BankAccountApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day2
{
    public class DemoBankkAccount
    {
        static void Main(string[] args)
        {
            BankAccount saurabhAccount = new BankAccount("Saurabh", 900);

            Console.WriteLine($"Account : {saurabhAccount.Number} was created for {saurabhAccount.Owner} with deposit of {saurabhAccount.Balance}");

            saurabhAccount.MakeDeposit(120, DateTime.Now, "Got Intern Salary");

            saurabhAccount.MakeDeposit(200, DateTime.Now, "Got First Salary");

            saurabhAccount.MakeWithdrawal(100, DateTime.Now, "Buy IPod");

            Console.WriteLine("My Current Balance is: " + saurabhAccount.Balance);


            Console.WriteLine(saurabhAccount.GetTransactionHistory());

            BankAccount premAccount = new BankAccount("Prem", 1900);



            Console.WriteLine($"Account : {premAccount.Number} was created for {premAccount.Owner} with deposit of {premAccount.Balance}");

        }
    }
}
