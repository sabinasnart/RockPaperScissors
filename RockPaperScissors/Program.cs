using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] choices = { "камень", "ножницы", "бумага" };

            Random random = new Random();

            string playAgain = string.Empty;

            do
            {
                Console.WriteLine("Выберите: камень, ножницы или бумага:");
                string userChoice = Console.ReadLine().ToLower();

                if (Array.IndexOf(choices, userChoice) < 0)
                {
                    Console.WriteLine("Ошибка! Пожалуйста, выберите камень, ножницы или бумагу");
                    continue;
                }

                int computerChoiceIndex = random.Next(choices.Length);
                string computerChoice = choices[computerChoiceIndex];
                Console.WriteLine($"Ответ компьютера: {computerChoice}");

                if (userChoice == computerChoice)
                {
                    Console.WriteLine("Ничья!");
                }
                else if ((userChoice == "камень" && computerChoice == "ножницы")
                    || (userChoice == "ножницы" && computerChoice == "бумага")
                        || (userChoice == "бумага" && computerChoice == "камень"))
                {
                    Console.WriteLine("Вы выиграли!");
                }
                else
                {
                    Console.WriteLine("Вы проиграли!");
                }

                Console.WriteLine("Хотите сыграть снова? Ответы: y/n");
                playAgain = Console.ReadLine().ToLower();
            }
            while (playAgain == "y");
        }
    }
}
