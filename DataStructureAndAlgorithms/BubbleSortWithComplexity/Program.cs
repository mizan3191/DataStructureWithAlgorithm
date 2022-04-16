using System;

namespace BubbleSortWithComplexity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size :");
            var size = int.Parse(Console.ReadLine());
            var dataArray = new int[size];
            var copy = new int[size];

            for (int i = 0; i < size; i++)
            {
                var x = int.Parse(Console.ReadLine());
                dataArray[i] = x;
                copy[i] = x;
            }

            for(int i = 0; i < dataArray.Length; i++)
            {
                for(int j = 0; j < dataArray.Length -i-1; j++)
                {
                    if(dataArray[j] > dataArray[j+1])
                    {
                        var temp = dataArray[j+1];
                        dataArray[j+1] = dataArray[j];
                        dataArray[j] = temp;
                    }
                }
            }

            Console.Write("Unsorted data [");

            for (var i = 0; i < copy.Length; i++)
            {
                Console.Write($" {copy[i]}");
            }

            Console.Write(" ]");

            Console.WriteLine();
            Console.Write("Sorted data [");

            for (var i = 0; i < dataArray.Length; i++)
            {
                Console.Write($" {dataArray[i]}");
            }

            Console.Write(" ]");

        }
    }
}