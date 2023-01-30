using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramBatch
{
    internal class FibonacciSeries
    {
        public void CalculatedFibonacciSeries()
        {
            /* Fibonacci Series
         0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 14
         fib1,fib2,fib3,fib4,_________
         Fn = Fn-1 + Fn-2*/ // F1 & F2 is 0 & 1 resp
                            //F3 = F2+F1;
            //variable fib1 =0 and fib 2 = 1 (always start)
            int fib1 = 0, fib2 = 1;
            int fib3;
            int temp;
            Console.WriteLine("Enter the nth number Upto nth fibonacciSeries");
            int numberRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("FibonacciSeries");
            Console.WriteLine(fib1); // for position 1
            Console.WriteLine(fib2); // for position 2
            for(int i = 3; i <= numberRange; i++)  //start position by 3
            {
                fib3 =fib2+fib1;
               // Fn = Fn-1 + Fn-2
                Console.WriteLine(fib3);
                fib1 = fib2;  
                fib2 = fib3;  
            }

        }
    }
}
