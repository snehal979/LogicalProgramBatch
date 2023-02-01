using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramBatch
{
    internal class ReverseNumber
    {
        public void CalculateReverseNumber()
        {
            Console.WriteLine("Enter the Number For Revese");
            int number = Convert.ToInt32(Console.ReadLine());
            //Variable
            int reverse=0;
            int remainder;
        
            while(number != 0)
            {
                remainder=number %10;//4
                reverse = reverse*10+remainder; //4
                number = number/10;//123   
            }
            Console.WriteLine(reverse);
        }
    }
}
