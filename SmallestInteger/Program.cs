using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallestInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int randomNumber, length, smallestNumber, highestNumber;

            Random rnd = new Random();
            length = rnd.Next(1, 10);

            for (int i = 0; i < length; i++)
            {
                randomNumber = rnd.Next(-100, 100);
                numbers.Add(randomNumber);
                Console.Write("\t" + numbers[i]);
            }

            smallestNumber = numbers.Min();
            highestNumber  = numbers.Max();

            Console.WriteLine();
            Console.WriteLine("Smallest number : {0}", smallestNumber);
            Console.WriteLine("Highest number  : {0}", highestNumber);

            Console.ReadKey();
        }
    }
}
