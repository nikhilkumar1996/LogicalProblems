using System;
namespace LogicalPrograms
{
    public class Program
    {

        public static void Main()
        {
            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine("\n 1. Fibonacci Series \n" +
                              "\n 2. Perfect Numbers \n" +
                              "\n 3. Prime Number   \n" +
                              "\n 4. Reverse Number \n" +
                              "\n 5. Coupon Number  \n" +
                              "\n 6. Stop Watch     \n" +
                              "\n 7. Exit \n ");
            Console.WriteLine("Choose Progrmas");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter a Number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    FibonacciSeries series = new FibonacciSeries();
                    series.Sum(num);
                    break;

                case 2:
                    PerfectNumber PN = new PerfectNumber();
                    PN.Remainder();
                    break;

                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Number();
                    break;

                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.Number();
                    break;

                case 5:
                    
                    CouponNumbers CN=new CouponNumbers();
                    CN.RandomNumber();

                    break;

                case 6:
                    Stopwatches stopwatch=new Stopwatches();
                    
                    break;
                    

                case 7:
                    Console.WriteLine("Exit");
                    break;



                default:
                    Console.WriteLine("Enter Correct Options");
                    break;
            }
        }

    }
        
}
