using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = new int[] { 10,5,6,12, 3 };
            var count = 0;

            for (int i = 0; i < number.Length; i++) 
            { 
                for(int j = 0; j < number.Length- i - 1; j++)
                {
                    count++;

                    if(number[j] > number[j+1])
                    {
                        var temp = number[j];
                        number[j] = number[j+1];
                        number[j+1] = temp;
                    }
                }
            }

            for(int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            Console.WriteLine($"Loop count: {count}");
        }
    }
}