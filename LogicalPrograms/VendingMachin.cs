using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class VendingMachin
    {
		// Static Variables i for indexing the array and total for calculating the total Notes
		static int i = 0;
		public static int total = 0;

		//Initialization of New Array
		public static int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
		static int money;

		// Function for Calculating the notes
		public static int calculate(int money, int[] notes)
		{
			//calling calculate Function
			int rem;
			if (money == 0)
			{
				return -1;
			}
			else
			{
				if (money >= notes[i])
				{
					// logic for Calculating The notes
					int calNotes = money / notes[i];
					rem = money % notes[i];
					money = rem;
					total += calNotes;
					Console.WriteLine(notes[i] + " Notes ---> " + calNotes);
				}
				i++;
				return calculate(money, notes);
			}
		}
	}
}
