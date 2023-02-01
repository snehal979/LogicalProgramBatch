using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramBatch
{
    internal class TemperaturConversion
    {
        public void ConvertTemperatureConversion()
        {
            Console.WriteLine("Enter the tempeture");
            double temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select 1-Celsius to Fahrenheit , 2-Fahrenheit to Celsius");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    double fahrenheit = (temperature * 9/5)+ 32;
                    Console.WriteLine("{0}C Celsius_to_Fahrenheit {1}F : ",temperature,fahrenheit);
                    break;
                case 2:
                    double celsius = (temperature - 32) * 5/9;
                    Console.WriteLine("{0}F Fahrenheit_to_Celsius {1}C :",temperature,celsius);
                    break;
            }
        }
    }
}
