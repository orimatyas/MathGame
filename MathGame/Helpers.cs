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

        internal static int bigNum = 100;
        internal static int smallNum = 50;

        internal static int[] GetDivisionNumbers()
        {
            GetDivisionCaps();
            var random = new Random();
            int firstNumber = random.Next(1, bigNum);
            int secondNumber = random.Next(1, smallNum);
            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, bigNum);
                secondNumber = random.Next(2, smallNum);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        private static int GetDivisionCaps()
        {
            switch (difficultyCap)
            {
                case 10:
                    bigNum = 100;
                    smallNum = 50;
                    break;
                case 100:
                    bigNum = 500;
                    smallNum = 350;
                    break;
                case 1000:
                    bigNum = 1000;
                    smallNum = 750;
                    break;
            }
            return bigNum;
            return smallNum;
        }

        internal static List<Game> games = new();

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
            Console.Clear();
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

        internal static string ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Please enter a number");
                result = Console.ReadLine();
            }
            return result;
        }

        internal static string difficultyLevel = "Easy";
        
        internal static int difficultyCap = 10;

        internal static int GetDifficultyCap()
        {
            switch (difficultyLevel)
            {
                case "Easy":
                    difficultyCap = 10;
                    break;
                case "Medium":
                    difficultyCap = 100;
                    break;
                case "Hard":
                    difficultyCap = 1000;
                    break;
            }
            return difficultyCap;
        }

        internal static void DifficultyChoice()
        {
            Console.WriteLine($@"Selected difficulty level: {difficultyLevel}
Select a difficulty level:
1. Easy
2. Medium
3. Hard");

            int choice = GetUserChoice();


            switch (choice)
            {
                case 1:
                    difficultyLevel = "Easy";
                    GetDifficultyCap();
                    break;
                case 2:
                    difficultyLevel = "Medium";
                    GetDifficultyCap();
                    break;
                case 3:
                    difficultyLevel = "Hard";
                    GetDifficultyCap();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
        
        static int GetUserChoice()
        {
            int choice;
            bool isValidChoice = false;

            do
            {
                Console.Write("Enter your choice: ");
                isValidChoice = int.TryParse(Console.ReadLine(), out choice);

                if (!isValidChoice || choice < 1 || choice > 3)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    isValidChoice = false;
                }
            } while (!isValidChoice);

            return choice;
        }

    }
    
}
