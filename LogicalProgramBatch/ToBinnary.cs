using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramBatch
{
    internal class ToBinnary
    {
        public static void ConvertBinary()
        {
            //Conversion of Integer to BINARY
            // 2^0=1 -1st position  
            //2^1 =2 - 2nd position
            //2^2=4; -3rd position
            //2^3=8; -4th position
            //2^4=16; -5 5th position
            //2^5 =32 -6th position
            //2^6 =64 -7th position
            //2^7=128 8th position
            /*Math formula to calculate binary number 
             34%2 =0  34/2 =17;
            17%2=1     17/2=8
            8%2 =0     8/2=4
            4%2=0      4/2=2
            2%2=0       2/2=1
            1%2=1        1/2=0
            Binary number is 100010*/  
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            string result ="";
            while (number !=0 )  // 0 or 1 are binary code
            {
                int remainder = number%2
                result=remainder+result;
                number =number/2;
            }
            Console.WriteLine(result);
            Console.WriteLine("Total bits for the number convert to binary "+result.Length);
        }
    }
}
