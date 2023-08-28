using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class BankAccount {
        private double balance=0;
        public void Deposit() {
            Console.WriteLine("input the amount you want to deposit:");
            double n = Convert.ToDouble(Console.ReadLine());
            balance += n;
        }
        public void Withdraw() {
            Console.Write("would you wish to withdraw: ");
            string text = Console.ReadLine();
            if (text == "yes")
            {
            Console.WriteLine("enter the amount you wish to withdraw");
            double n = Convert.ToDouble(Console.ReadLine());
	    if (n > balance)
	    {
		    Console.WriteLine("Oops! You can\'t withdraw that amount");
	    }
	    else
	    {
            balance -= n;
            Console.WriteLine("withdrawal success");
	    } 
            }
        }
        public double GetBalance() {
            Console.Write("your account balance is: ");
            return balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount();
            b.Deposit();
            b.Withdraw();
            Console.WriteLine(b.GetBalance());
        }
    }
}
