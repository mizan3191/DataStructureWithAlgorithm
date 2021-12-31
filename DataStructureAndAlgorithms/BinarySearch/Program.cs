using System;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = new int[] { 3, 5, 6, 12, 15 };
            var max = number.Length-1;
            var min = 0;
            var mid = 0;
            bool get = false;
            var target = 5;

            while(min <= max)
            {
                mid = (max + min) / 2;

                if (number[mid] == target)
                {
                    get = true;
                    break;
                }

                if(number[mid] > target)
                { 
                    max = mid-1; 
                }
                else
                {
                    min = mid+1;
                }
            }
            if(!get)
                Console.WriteLine($"Item not found");
            else
                Console.WriteLine($"Item {number[mid]} found position: {mid+1}");
        }
    }
}
