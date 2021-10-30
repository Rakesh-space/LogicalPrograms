using System;

namespace LogicalProgram
{
    class Utility
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Fibonassi\n2.Primenumber Series\n3.Reversenomber\n4.Perfectnumber\n5.Coupon\n6.Stopwatch\n7.Vending Machine\n8. DayOfWeek\n9.TempretureConversion\n10.ComputeSQRT\n11.MonthlyPayment ");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FibonassiSerious fibonassiSerious = new FibonassiSerious();
                    fibonassiSerious.fibonassiSerious();
                    break;

                case 2:
                    PrimeNo primeNo = new PrimeNo();
                    primeNo.primeNo();
                    break;

                case 3:
                    ReverseNumber reverseNumber=new ReverseNumber();
                    reverseNumber.reverseNumber();
                    break;

                case 4:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.perfectNumber();
                    break;

                case 5:
                    CoupanNumber coupanNumber = new CoupanNumber();
                    coupanNumber.coupanNumber();
                    break;

                case 6:
                    StopWatch stopWatch = new StopWatch();
                    stopWatch.start();
                    stopWatch.stop();
                    stopWatch.getElapsedTime();
                    stopWatch.getElapsedTimeSecs();
                    break;

                case 7:
                    Console.WriteLine("Enter the Amount:");
                    int money = Convert.ToInt32(Console.ReadLine());

                    // Creating The Object of Vending MAchine class
                    VendingMachin.calculate(money, VendingMachin.notes);
                    Console.WriteLine("Total Number of Notes are :" + VendingMachin.total);
                    break;

                case 8:
                    DayOfWeek dayOfWeek=new DayOfWeek();
                    dayOfWeek.dayOfWeek();
                    break;

                case 9:
                    TempretureConversion tempretureConversion = new TempretureConversion();
                    tempretureConversion.tempretureConversion();
                    break;

                case 10:
                    ComputeSQRT computeSQRT = new ComputeSQRT();
                    computeSQRT.computeSQRT();
                    break;

                case 11:
                    MonthlyPayment monthlyPayment=new MonthlyPayment();
                    monthlyPayment.monthlyPayment();
                    break;

                default:
                    Console.WriteLine("Invalid choice.. ");
                    break;
            }
    }
}
