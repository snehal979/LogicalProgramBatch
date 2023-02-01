using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramBatch
{
    internal class DayOfWeek
    {
        public static void WeekDayOfDay(int day,int month,int year)
        {
            //variable
            int y0, x, m0, d0;
            //Formula
            y0 = year - (14 - month) / 12;
            x = y0 + y0/4 - y0/100 + y0/400;
            m0 = month + 12 * ((14 - month) / 12) - 2;
            d0 = (day + x + 31 * m0 / 12) % 7;

            switch (d0)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
