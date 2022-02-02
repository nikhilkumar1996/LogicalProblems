using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public void Sum(int number)
        {
            int firstNumber = 0, secondNumber = 1, thirdNumber = 0;
            Console.WriteLine("FibonacciSeries:");
            Console.WriteLine(firstNumber +"\n"+ secondNumber +" ");
            for (int i = 0; i <= number; i++)
            {

                thirdNumber = firstNumber + secondNumber;
                Console.WriteLine(thirdNumber +" ");
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
            
        }
    }
}
