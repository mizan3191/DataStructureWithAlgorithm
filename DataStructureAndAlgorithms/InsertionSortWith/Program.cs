using System;

namespace InsertionSortWith
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
                var x= int.Parse(Console.ReadLine());
                dataArray[i] = x;
                copy[i] = x;
            }


            for(int i = 1; i < dataArray.Length; i++)
            {
                var value = dataArray[i];
                var j = i - 1;

                while(j >= 0 && dataArray[j] > value)
                {
                    dataArray[j+1] = dataArray[j];
                    j--;
                }
                dataArray[j+1] = value;
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