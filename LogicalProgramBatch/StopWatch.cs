using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramBatch
{
    internal class StopWatch
    {
        public void CalculateTime()
        {
            DateTime dateTime = DateTime.Now;
            //Variable for Start
            int starthour = dateTime.Hour;
            int startMin = dateTime.Minute;
            int startSec = dateTime.Second;
            int startMilliSec = dateTime.Millisecond;
            // Start the program
            Console.WriteLine("Start the Program Yes or no");
            string startInput = Console.ReadLine().ToLower();
            if (startInput.Equals("yes"))
            {
                Console.WriteLine("Program Starting ..........");
                Console.WriteLine("End the program yes or no");
                //End the Program
                string endInput = Console.ReadLine().ToLower();
                if (endInput.Equals("yes"))
                {
                    DateTime dateTime1 = DateTime.Now;
                    int endhour = dateTime1.Hour;
                    int endMin = dateTime1.Minute;
                    int endSec = dateTime1.Second;
                    int endMilliSec = dateTime1.Millisecond;
                    //Calculate the elapsed time between start and end 
                    Console.WriteLine("Total Time is Requried the Run Program " +"\n hour :"+(endhour-starthour)+"\nMin :"
                       +(endMin-startMin)+"\n Second : "+(endSec-startSec)+"\n MilliSecond :"+(endMilliSec-startMilliSec));
                    Console.WriteLine("{0:HH:ss:ff}", dateTime1);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        /// <summary>
        /// OTHER METHOD FOR CALCULATING ELAPSED TIME 
        /// </summary>
        public void OtherMethodElapsedIime()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("{0:hh:mm:ss:ff}",dateTime);
            Console.WriteLine("Start the Program ..........yes or no");
            string start = Console.ReadLine().ToLower();
            if (start=="yes")
            {
                Console.WriteLine("Program running ..........");
                Console.WriteLine("End the program yes or no");
                //End the Program
                string end = Console.ReadLine().ToLower();
                if (end=="yes")
                {
                    Console.WriteLine("End the program");
                    DateTime dateTime1 = DateTime.Now;
                    Console.WriteLine("{0:hh:mm:ss:ff}", dateTime1);
                    Console.WriteLine("(Elaspsed time" +(dateTime1- dateTime));
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
