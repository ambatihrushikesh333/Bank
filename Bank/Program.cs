
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount
    {
        int AccountNumber;
        int Balance;
        static string BankName = "SBI";

        public BankAccount(int accountnumber, int balance)
        {
            this.AccountNumber = accountnumber;
            this.Balance = balance;
        }

        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("Amount Deposited: " + amount);
        }

        public void Withdraw(int amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Amount Withdrawn: " + amount);
            }
        }

        public void Display()
        {
            Console.WriteLine("Bank Name: " + BankName);
            Console.WriteLine("Bank Account Number: " + AccountNumber);
            Console.WriteLine("Bank Balance: " + Balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount p1= new BankAccount(12345, 10000);
            p1.Display();
            Console.WriteLine("=======================================");
            p1.Deposit(5000);
            Console.WriteLine("=======================================");
            Console.WriteLine("After Deposit : ");
            p1.Display();
            Console.WriteLine("=======================================");
            p1.Withdraw(7000);
            Console.WriteLine("=======================================");
            Console.WriteLine("After Withdraw : ");
            p1.Display();
            Console.ReadLine();
        }
    }
}
