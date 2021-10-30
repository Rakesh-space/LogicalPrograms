using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class MonthlyPayment
    {
        public void monthlyPayment()
        {
			// Prompt the user to enter the loan amount,
			// the number of years and the annual interest rate
			Console.WriteLine("\n Enter the Loan Amount: ");
			double loanAmount = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("\nEnter the Number of Years: ");
			int years = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nEnter the Annual Interest Rate:");
			double annualRate =Convert.ToDouble(Console.ReadLine());

			// Calculate monthly interest rate
			double monthlyRate = annualRate / 1200;

			// Calculat montly payment
			double monthlyPayment = loanAmount * monthlyRate / (1 - 1 /Math.Pow(1 + monthlyRate, years * 12));

			// Display montly payment
			Console.WriteLine("\nMonthly Payment:", monthlyPayment);

			// Display total payment
			Console.WriteLine("\nTotal Payment:", (monthlyPayment * 12) * years);

			// Create amortization schedule
			double balance = loanAmount,principal, interest;
			Console.WriteLine("\nMonthly Payment History is:");
			for (int i = 1; i <= years * 12; i++)
			{
				interest = monthlyRate * balance;
				principal = monthlyPayment - interest;
				balance = balance - principal;
				Console.WriteLine("\nPayment Interest Principal Balance", i, interest,principal, balance);
			}
		}
    }
}
