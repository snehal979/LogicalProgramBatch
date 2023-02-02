using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramBatch
{
    internal class VendingMachine
    {
        //Initilization of array
        int[] noteArray = { 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        public void NoteVendingMachine(int amount)
        {
            if (amount!=0)
            {
                int rem;
                int i = 0;
                while (noteArray.Length > i)
                {
                    if (amount >= noteArray[i])
                    {
                        int currency = amount/noteArray[i];  
                        rem = amount%noteArray[i];
                        amount =rem;
                        Console.WriteLine("Note "+noteArray[i]+" "+currency);
                    }
                    i++;
                }
            }
            else
            {
                Console.WriteLine("amount is zero");
            }
        }
    }
}
