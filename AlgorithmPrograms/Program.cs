using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");
            Console.WriteLine("1.Bubble sort" + 
                              "\n2.Insertionsort" +
                              "\n3.Angram Check" +
                              "\n4.Prime Number" 
                             );

            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    BubbleSort.BubbleSorting();
                    break;

                case 2:
                    string[] names = { "apple", "grapes", "banana", "apples" };
                    InsertionSort.InsertSort(names);
                    foreach (var item in names)
                    {
                    Console.WriteLine(item);
                    }
                    break;

                case 3:
                    Anagram anagram = new Anagram();
                    anagram.Check();
                    break;

                case 4:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.PrimeRange();
                    break;
            }
        }
    }
}
