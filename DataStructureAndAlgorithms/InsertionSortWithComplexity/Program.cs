using System;

namespace InsertionSortWithComplexity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size :");
            var size = int.Parse(Console.ReadLine());
            var dataArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                dataArray[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 1; i < dataArray.Length; i++)
            {
                var value = dataArray[i];
                var j = i - 1;

                while(j >= 0 && dataArray[j]> value)
                {
                    dataArray[j+1] = dataArray[j];
                    j--;
                }

                dataArray[j+1] = value;
            }

            for (var i = 0; i < dataArray.Length; i++)
            {
                Console.WriteLine(dataArray[i]);
            }
        }
    }
}

// best case time complexity O(n)
// best case space complexity O(1)

// Worse case time comlexity O(n^2)
// Worse case time complexity O(n^2)