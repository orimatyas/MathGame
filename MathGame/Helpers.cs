using MathGame.Model;

namespace MathGame
{
    internal class Helpers
    {
        static List<Game> games = new();

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            int firstNumber = random.Next(1, 99);
            int secondNumber = random.Next(1, 99);
            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(2, 12);
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
                Console.WriteLine($"{game.Type} - {game.Date} - {game.Score}");
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }
        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
            });
        }
        internal static void QuitGame()
        {
            Console.Clear();
            Console.WriteLine("Goodbye!");
            Environment.Exit(1);
        }
    }
}
