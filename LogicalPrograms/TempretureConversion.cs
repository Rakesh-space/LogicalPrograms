using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class TempretureConversion
    {
        public void tempretureConversion()
        {
            Console.WriteLine("\nInput a degree in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInput a degree in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

             celsius = ((5 * (fahrenheit - 32.0)) / 9.0);
             fahrenheit=(celsius * 9 / 5)+32;
            
            Console.WriteLine(fahrenheit + " degree Fahrenheit is equal to " + celsius + " in Celsius");
            Console.WriteLine(celsius+ " degree Fahrenheit is equal to " + fahrenheit + " in Celsius");
        }
    }
}
