using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the1Riddle
{
	class BankAccount
	{
		private double balance = 0;

		public void Deposit()
		{
			Console.Write("Enter the amount you want to deposit:");
			double amount = GetValidAmountInput();
			balance += amount;
			Console.WriteLine($"\n          _____Deposit of {amount:C} successful_____\n");
		}

		public void Withdraw()
		{
			Console.Write("Do you wish to withdraw (yes/no): ");
			string response = Console.ReadLine().ToLower();
			if (response == "yes" || response == "y")
			{
				Console.WriteLine("Enter the amount you wish to withdraw: ");
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

	class User
	{
	    private string name;
	    private string password;
	    private int loginAttempts = 0;

	    public void CreateAccount()
	    {
	        Console.WriteLine("*************** Welcome to the Platform ***************");
	        Console.WriteLine("\n ...To continue, please create an account \n");
	        Console.Write("Enter your Name: ");
	        name = Console.ReadLine();
	        Console.Write("Enter your password: ");
	        password = (Console.ReadLine());
	        Console.WriteLine("\n \n               _____Account Creation Success_____");
	        Console.WriteLine($"\n \n*************** Welcome to your New account {name} ***************\n");
	    }

	    public bool Authenticate()
	    {
	        while (loginAttempts < 3)
	        {
	            Console.WriteLine("To continue, please enter your password: \n");
	            string inputPassword = (Console.ReadLine());
	            if (inputPassword == password)
	            {
	                Console.WriteLine("            _____Login successful_____\n");
	                return true;
	            }
	            else
	            {
	                Console.WriteLine("            ....Account login Failure");
	                loginAttempts++;
	            }
	        }
	        Console.WriteLine("\n...Authentication failed. Come back after 30 minutes and try again");
	        Console.WriteLine("\n \n**************** Account Suspended ***************\n");
	        return false;
	    }
	}

	class Program
	{
		static void Main(string[] args)
		{
			User user = new User();
			user.CreateAccount();
			BankAccount account = new BankAccount();
			account.Deposit();
			if (user.Authenticate())
			{
				account.Withdraw();
				Console.WriteLine($"Your account balance is: {account.GetBalance():C}");
				Console.WriteLine("\n\n         ______Thankyou for using our Services______");
			}
		}
	}
}
