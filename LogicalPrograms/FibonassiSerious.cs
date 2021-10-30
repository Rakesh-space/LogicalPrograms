using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class FibonassiSerious
    {
        public void fibonassiSerious()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            //printing 0 and 1
            Console.Write(n1 + " " + n2 + " ");
            //loop starts from 2 because 0 and 1 are already printed  
            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
