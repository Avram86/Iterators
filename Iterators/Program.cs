using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterators
{
    class Program
    {
        static void Main(string[] args)
        {

            NumbersGenerator nrGen = new NumbersGenerator();
            EvenNumbersGenerator evenNrGen = new EvenNumbersGenerator(nrGen);

            int maxCout = 10;
            int currentCount = 0;

            foreach(int nr in evenNrGen)
            {
                Console.WriteLine($"Nr={nr}");
                currentCount++;
                if (currentCount >= maxCout)
                {
                    break;
                }
            }

            foreach (var elem in Fibonacci.Get(10))
            {
                Console.WriteLine(elem);
            }

            ThreeElemCollection<int> myCollection2 = new ThreeElemCollection<int>(1, 2, 3);

            foreach (var elem in myCollection2)
            {
                Console.WriteLine(elem);
            }

            MyIntegersCollection myCollection = new MyIntegersCollection(1, 2, 3);

           foreach(var elem in myCollection)
            {
                Console.WriteLine(elem);
            }
        }
        private static void Comparison_Between_IEnumerableANdRawLoop()
        {

        }
    }
}
