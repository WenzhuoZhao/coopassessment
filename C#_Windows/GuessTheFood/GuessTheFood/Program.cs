using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheFood
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = PopulateFood();
            UserGuess(food);
            Console.ReadLine();
        }

        static string PopulateFood()
        {
            List<string> foods = new List<string>() {"Pizza", "Pasta", "Salmon", "Steak", "Miso"};
            Console.WriteLine("The below is the available foods:");
            foreach( string food in foods)
            {
                Console.Write(food+" ");
            }
            Console.WriteLine();
            Random random = new Random();
            int index = random.Next(foods.Count);
            return foods[index];
        }

        static void UserGuess(string food)
        {
            int num = 3;
            while (num > 0)
            {
                Console.Write("Guess a food: ");
                string UserAnswer = Console.ReadLine();
                if (UserAnswer.Equals(food, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("You're right!");
                    break;
                }
                else
                {
                    num--;
                    Console.WriteLine("Wrong answer, you have {0} chances!", num);
                }
            }
        }

    }
}
