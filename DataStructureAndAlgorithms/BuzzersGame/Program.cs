using System;

namespace BuzzersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var participantList = new int[10];

            for(int i = 0; i < participantList.Length; i++)
            {
                participantList[i] = 0;
            }

            for(int i = 0; i < 5; i++)
            {
                var id = int.Parse(Console.ReadLine());
                participantList[id-1]++;
            }

            var maxscore = 0;

            for(int i = 0; i < participantList.Length; i++)
            {
                if(participantList[i] > maxscore)
                {
                    maxscore = participantList[i];
                }
            }

            for(var i = 0; i < participantList.Length; i++)
            {
                if(maxscore == participantList[i])
                {
                    Console.WriteLine($"Winner id {i+1}");
                    break;
                }
            }
        }
    }
}