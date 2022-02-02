using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public void Number()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int Comparenum =num;
            int digit,sum=0;
            while(num>0)
            {
                digit = num % 10;
                sum = sum * 10 + digit;
                num = num / 10;

            }
            if (Comparenum == sum)
            {
                Console.WriteLine("Number is a Reverse Number of itself");
            }
            else
            {
                Console.WriteLine("Number is irreversible");
            }
        }
    }
}
