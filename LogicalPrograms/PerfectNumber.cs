using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void Remainder()
        {
            Console.WriteLine("Enter a number");
            int number=Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for(int divisor=1;divisor<number;divisor++)
            {
                if (number % divisor == 0)
                {
                    Console.WriteLine("divisor of perfecr number{0}={1}",number,divisor);
                    sum = sum + divisor;
                    
                    
                }
                
                
              
            }
                Console.WriteLine("Sum of Divisors=" + sum);

            if (number == sum)
            {
                Console.WriteLine("Number is a perfect number");
            }
            else
            {
                Console.WriteLine("number is not a perfect number");
            }
            
        }
    }
}
