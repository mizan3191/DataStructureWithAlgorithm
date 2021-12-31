using System;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = new int[] { 10, 5, 6, 12, 3 };
            var count = 0;

            for(int i = 0; i < number.Length; i++)
            {
                var min_value = i;

                for (int j = i+1; j < number.Length-1; j++)
                {
                    if(number[min_value] > number[j])
                    {
                        min_value = j;    
                    }

                    count++;
                }

                if(min_value != i)
                {
                    var temp = number[i];
                    number[i] = number[min_value];
                    number[min_value] = temp;
                }
            }
            
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            Console.WriteLine($"Loop count: {count}");
        }
    }
}