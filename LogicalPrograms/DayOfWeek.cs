using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class DayOfWeek
    {
        public void dayOfWeek()
        {

            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("\n Enter the Month:");
                int m = Convert.ToInt32(Console.ReadLine());
                if (m < 1 || m > 12)
                {
                    Console.WriteLine("Months are between 1 and 12");
                    continue;
                }

                Console.WriteLine("\n Enter the Day:");
                int d = Convert.ToInt32(Console.ReadLine());
                if (d < 1 || d > 31)
                {
                    Console.WriteLine("Days are between 1 and 31");
                    continue;
                }

                Console.WriteLine("\n Enter the Year:");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y < -10000 || y > 10000)
                {
                    Console.WriteLine("Years are between -10000 and 10000");
                    continue;
                }

                int y0 = y - (14 - m) / 12;
                int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                int m0 = m + 12 * ((14 - m) / 12) - 2;
                int d0 = (d + x + 31 * m0 / 12) % 7;
                d0 = (d + x + 31 / 12) % 7;

                switch (d0)
                {
                    case 1:
                        Console.WriteLine("\nSunday..");
                        break;
                    case 2:
                        Console.WriteLine("\nMonday..");
                        break;
                    case 3:
                        Console.WriteLine("\nTuesday..");
                        break;
                    case 4:
                        Console.WriteLine("\nWednesday..");
                        break;
                    case 5:
                        Console.WriteLine("\nThursday..");
                        break;
                    case 6:
                        Console.WriteLine("\nFriday..");
                        break;
                    case 7:
                        Console.WriteLine("\nSaturday..");
                        break;

                }

                Console.WriteLine("The day of the week is " + d0);
            }
        }
    }
}
