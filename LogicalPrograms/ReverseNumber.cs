using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class ReverseNumber
    {
        public void reverseNumber()
        {
            int n, rem, rev = 0;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse number is:" + rev);
        }
    }
}
