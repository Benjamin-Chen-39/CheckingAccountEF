using System;
using System.Linq;
using lib;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new Context();
            // Create
            Console.WriteLine("Inserting a new account");
            var checkingAccount = new CheckingAccount();
            Console.WriteLine($"checkingAccount before state : {db.Entry(checkingAccount).State}");
            db.Add(checkingAccount);
            Console.WriteLine($"checkingAccount add state : {db.Entry(checkingAccount).State}");
            db.SaveChanges();
            Console.WriteLine($"checkingAccount after state : {db.Entry(checkingAccount).State}");

            // Read
            Console.WriteLine("Querying for a checking account");
            var firstAccount = db.CheckingAccounts.OrderBy(c => c.Id).First();
            Console.WriteLine($"First Account: {firstAccount.Id}");

            // Update
            Console.WriteLine("Updating the account and adding a log");
            checkingAccount.Balance = 1000;
            Console.WriteLine($"account alter state : {db.Entry(checkingAccount).State}");
            var log = new Log { TransactionType = "deposit", Amount = 1000 };
            checkingAccount.Logs.Add(log);
            db.SaveChanges();
            Console.WriteLine($"account after state : {db.Entry(checkingAccount).State}");
        }
    }
}
