using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOffsets
{
	class BankAccount
	{
		private double balance = 0;

		public void Deposit()
		{
			Console.WriteLine("Enter the amount you want to deposit:");
			double amount = GetValidAmountInput();
			balance += amount;
			Console.WriteLine($"Deposit of {amount:C} successful");
		}

		public void Withdraw()
		{
			Console.Write("Do you wish to withdraw (yes/no): ");
			string response = Console.ReadLine().ToLower();
			if (response == "yes")
			{
				Console.WriteLine("Enter the amount you wish to withdraw:");
				double amount = GetValidAmountInput();
				if (amount > balance)
				{
					Console.WriteLine("...\nOops! You can't withdraw more than your balance");
				}
				else
				{
					balance -= amount;
					Console.WriteLine($"Withdrawal of {amount:C} successful");
				}
			}
		}

		public double GetBalance()
		{
			return balance;
		}

		private double GetValidAmountInput()
		{
			double amount;
			while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
			{
				Console.Write("Invalid input.\nPlease enter a valid positive amount: ");
			}
			return amount;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			BankAccount account = new BankAccount();
			account.Deposit();
			account.Withdraw();
			Console.WriteLine("...\nThankyou for using our Services");
			Console.WriteLine($"Your account balance is: {account.GetBalance():C}\n...");
		}
	}
}
