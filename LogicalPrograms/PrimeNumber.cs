using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void Number()
        {
            Console.WriteLine("Enter any number");
            
            int num=Convert.ToInt32(Console.ReadLine());
            int n =num;
            IEnumerable<int> range=Enumerable.Range(2, num--);
            foreach (int x in range)
            {
                if (num % x == 0)
                {
                    Console.WriteLine("{0}is not a prime number",n);
                    break;
                }
                else
                {
                    Console.WriteLine("{0}is a Prime Number",n);
                }
            }
        }
    }
}
