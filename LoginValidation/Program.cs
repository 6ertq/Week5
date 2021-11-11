using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string rightUsername = "admin";
            string rightPassword = "admin1234";
            
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine("Sisestage kasutajatunnus:");
                string UserUsername = Console.ReadLine();

                Console.WriteLine("Sisestage salasõna:");
                string UserPassword = Console.ReadLine();
                Console.WriteLine();

                if (rightUsername == UserUsername && rightPassword == UserPassword)
                {
                    Console.WriteLine("Tere tulemast!");
                    i = 0;
                }
                else if (i == 1) {
                    Console.WriteLine("Vale kasutajatunnus või salasõna. Katsed on otsas.");   
                }     
                else
                    Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
        }
    }
}
