using System;

namespace SelectionSortWithComplexity
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

            for(int i = 0; i < dataArray.Length; i++)
            {
                var min = i;
                for(int j = i+1; j < dataArray.Length; j++)
                {
                    if(dataArray[j] < dataArray[min])
                    {
                        min = j;
                    }
                }

                if(min != i)
                {
                    var temp = dataArray[i];
                    dataArray[i] = dataArray[min];
                    dataArray[min] = temp;
                }
            }

            for(var i = 0; i < dataArray.Length; i++)
            {
                Console.WriteLine(dataArray[i]);
            }
        }
    }
}

// best case time complexity O(n^2)
// best case space complexity O(n^2)

// Worse case time comlexity O(n^2)
// Worse case time complexity O(n^2)