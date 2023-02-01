using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramBatch
{
    internal class MonthlyPayment
    {
        public static void CalculateMonthlyPayment(int P,int Y, int R)
        {
            //P = principle, Y = year R=Rate of interst n = time
            //Variable
           double r =(double)R / (12 * 100);  
            int n= 12 * Y;
            double payment = (P * r) /(1 - (Math.Pow((1 + r), - n)));
            Console.WriteLine("Monthly payment you have to make for "+Y +" years is " +payment);
        }
    }
}
