using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public static void BubbleSorting()
        {
            int[] arrayNumber = { 78, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j <= arrayNumber.Length - 2; j++)
            {
                for (int i = 0; i <= arrayNumber.Length - 2; i++)
                {
                    if (arrayNumber[i] > arrayNumber[i + 1])
                    {
                        temp = arrayNumber[i + 1];
                        arrayNumber[i + 1] = arrayNumber[i];
                        arrayNumber[i] = temp;
                    }
                }   
            }
            Console.WriteLine("Sorted Numbers : ");
            foreach (int number in arrayNumber)
            {
                Console.Write(number + " ");
            }

        }
    }
}
