using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeNumber
    {
        public void PrimeRange()
        {
            const int START = 0;
            const int END = 1000;
            for(int i = START;i<=END;i++)
            {
                int temp = 0;
                for(int j=2;j<=i/2;j++)
                {
                    if(i%j==0)
                    {
                        temp++;
                        break;
                    }
                }
                if(temp==0 && i !=1)
                {
                    Console.WriteLine("Prime Number : "+i);
                }
            }

        }
    }
}
