using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramBatch
{
    internal class PerfectNumber
    {
        public void CheckNumberIsPerfect()
        {
            /* When the number is equal to the sum of its positive divisors
            excluding the number, it is called a Perfect Number.*/
            Console.WriteLine("Enter the number for Checking the Perfect Number or Not");
            int number = Convert.ToInt32(Console.ReadLine());
            //variable
            int sum = 0;
            for(int i = 1; i <= number/2; i++)
            {
                if (number % i == 0)
                {
                    sum+=i;
                }
            }
            if(sum == number)
            {
                Console.WriteLine("{0} the given number is Perfect Number",number);
            }
            else
            {
                Console.WriteLine("{0} the given number is Not Perfect Number",number);
            }
        }
    }
}
