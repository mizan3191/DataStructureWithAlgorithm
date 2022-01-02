using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackData
    {
        public int top = 0;
        public int max = 0;
        public int[] array = new int[10];
        public StackData(int size)
        {
            max = size;

        }
        public void push(int item)
        {
            if (top > max-1)
            {
                Console.WriteLine("Stack is full!");
            }
            else
            {
                array[top] = item;
                top = top + 1;
                Console.WriteLine($"Successful Inserted {item} position: {top - 1}");
            }
        }

        public int pop()
        {
            if(top > 0)
            {
                top = top - 1;
                Console.WriteLine($"Successful Deleted {array[top]} position: {top - 1}");
            }
            else
            {
                Console.WriteLine("Stack is empty!");
            }  
            return array[top];
        }
    }
}