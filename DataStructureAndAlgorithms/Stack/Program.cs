using System;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {

            var data = new StackData(10);
            data.push(1);
            data.push(2);
            data.push(3);
            data.push(10);
            data.push(13);
            data.push(22);
            data.push(33);
            data.push(44);
            data.push(55);
            data.push(66);
            data.push(43);
            data.push(53);
            data.push(63);
            data.push(73);
            data.push(83);
            data.push(94);

            data.pop();
            data.pop();
            data.pop();
            data.pop();
            data.pop();
            data.pop();

            data.push(63);
            data.push(73);
            data.push(83);
            data.push(94);

            Console.WriteLine("Program is Closed!");
        }

        
    }
}
