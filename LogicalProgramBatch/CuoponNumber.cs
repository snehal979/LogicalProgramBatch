using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramBatch
{
    internal class CuoponNumber
    {
        int count = 0;
        public void RandomCuoponNumber()
        {
            int[] randomCuoponArray = new int[10];
            Random random = new Random();

            for (int i = 0; i < randomCuoponArray.Length; i++)
            {
                int number = random.Next(1, 20);
                if (!IsExit(randomCuoponArray,number)) //false
                {
                    randomCuoponArray[i]=number;
                }
            }
            count++;
            //Display Random Number
            foreach(var data in randomCuoponArray)
            {
                Console.WriteLine("Random number are "+data+" ");
            }
            Console.WriteLine("{0} random numbers are needed to have 10 distinct coupon numbers:", count);
        }
        //Method for checking The value is exit or not
        public bool IsExit(int[]randomArrays,int ranNum)
        {
            foreach(int data in randomArrays)
            {
                if (data==ranNum)
                {
                    return true;
                }  
            }
            return false;
        }
    }
}
