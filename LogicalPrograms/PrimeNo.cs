using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class PrimeNo
    {
        public void primeNo()
        {
            int n, i;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("number is not prime"+i);
                }
                else
                {
                    Console.WriteLine("this is prime number"+i);
                }
            }
        }
    }
}
