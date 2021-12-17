using System;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = new int[] { 10, 5, 6, 12, 3 };
            var count = 0;

            
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            Console.WriteLine($"Loop count: {count}");
        }
    }
}
