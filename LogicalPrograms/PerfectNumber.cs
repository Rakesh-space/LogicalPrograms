using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class PerfectNumber
    {
        public void perfectNumber()
        {
            int n,sum = 0,number;
            Console.WriteLine("enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            n = number;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine("this is perfect number");
            }
            else
            {
                Console.WriteLine("this is not perfect number");
            }

        }
    }
}
