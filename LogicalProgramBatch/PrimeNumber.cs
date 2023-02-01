using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramBatch
{
    internal class PrimeNumber
    {
        public void CheckPrimeNumber()
        {
            //Prime Number  
            Console.WriteLine("Enter the number for Check The number is Prime Or Not Prime ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i = 1; i <= number; i++)
            {
                if(number%i == 0)
                {
                    count++;
                }
            }
            if(count == 2)
                Console.WriteLine("{0} the number is Prime Number",number);
            else
                Console.WriteLine("{0} the number is Not Prime Number",number);
        }
    }
}
