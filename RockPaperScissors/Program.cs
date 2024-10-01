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
            }
            while (playAgain == "y");
        }
    }
}
