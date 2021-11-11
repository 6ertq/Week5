using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
          
            int cpuScore = 0;
            int userScore = 0;

            for (int i = 1; i <= 3; i++)
            {
                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);

                int cpuThrowScore = cpuRandom;
                int userThrowScore = userRandom;

                Console.WriteLine($"{i}. viske korral viskas arvuti {cpuThrowScore} ja kasutaja {userThrowScore} silma");

                cpuScore += cpuThrowScore;
                userScore += userThrowScore;
            }

            Console.WriteLine();
            Console.WriteLine($"Arvuti viskas kokku {cpuScore} silma ja kasutaja {userScore} silma.");
            Console.WriteLine();

            if (userScore > cpuScore)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
            }
            else if (cpuScore > userScore)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
            }
            else
                Console.WriteLine("Viik!");
        }
    }
}
