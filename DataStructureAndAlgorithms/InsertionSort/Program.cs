using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var number = new int[] { 10, 5, 6, 12, 3 };
            var count = 0;
            for (int i = 1; i < number.Length; i++)
            { 
                var temp = number[i];
                var j = i-1;

                while(j >= 0 && number[j] > temp)
                {
                    number[j+1] = number[j];
                    j = j-1;
                    ++count;
                }
                number[j+1] = temp;   
            }

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            Console.WriteLine($"Loop count: {count}");

        }
    }
}
