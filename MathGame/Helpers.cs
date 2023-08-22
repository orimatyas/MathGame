using MathGame.Model;
using System.Xml.Linq;
using static MathGame.Model.Game;

namespace MathGame
{
    internal class Helpers
    {
        internal static string GetName()
        {
            Console.WriteLine("Hello, \nPlease type your name:");
            var name = Console.ReadLine();
            Console.Clear();
            return name;
        }

        internal static List<Game> games = new();

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            int firstNumber = random.Next(1, 100);
            int secondNumber = random.Next(1, 50);
            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 100);
                secondNumber = random.Next(2, 50);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("--Game History--");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type} - {game.Score} pts");
            }
            Console.WriteLine("----------------");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }
        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }
        internal static int questionNum = 3;
        internal static int QuestionNumbers()
        { 
            Console.WriteLine($@"Current number of questions {questionNum}
How many questions do you want to answer?");
            var num = Console.ReadLine();
            while (string.IsNullOrEmpty(num) || !Int32.TryParse(num, out _))
            {
                Console.WriteLine("Please enter a number");
                num = Console.ReadLine();
                Console.Clear();
            }
            questionNum = Convert.ToInt32(num);
            return questionNum;
        }

        internal static void SetColors()
        {
            var colorSelected = Console.ReadLine();

            switch (colorSelected.Trim().ToLower())
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                case "2":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "3":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "4":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "5":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

            Console.Clear();
        }

        internal static void QuitGame()
        {
            Console.Clear();
            Console.WriteLine("Goodbye!");
            Environment.Exit(1);
        }
    }
}
