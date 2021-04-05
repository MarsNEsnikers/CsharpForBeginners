using System;

namespace BlackJack
{


    class Program
    {
        static void Main(string[] args)
        {
            bool isPlayerContinue = true;
            bool isComputerContine = true;

            Random random = new Random();

            do
            {
                Console.WriteLine("Будешь тянуть курту? (y/n)");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    Console.WriteLine("Вы тяните карту");
                }

                if (answer == "n")
                {
                    Console.WriteLine("Вы пассуете");
                    isPlayerContinue = false;
                }

                //isComputerContine
                int decisionNumber = 0;

                decisionNumber = random.Next(0,2);

                if (decisionNumber == 0)
                {
                    Console.WriteLine("Бот тяните карту");
                }

                if (decisionNumber == 1)
                {
                    Console.WriteLine("Бот пассуете");
                    isComputerContine = false;
                }
            } while (isPlayerContinue || isComputerContine);

            
        }
    }
}
