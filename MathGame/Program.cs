using static System.Formats.Asn1.AsnWriter;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            List<string> games = new List<string>();
            string name = GetName();

            Menu(name);

            string GetName()
            {
                Console.WriteLine("Hello, \nPlease type your name:");
                var name = Console.ReadLine();
                Console.Clear();
                return name;
            }
            void Menu(string name)
            {
                Console.WriteLine($"Hello {name}. Today it's {date}. It's time to work on your math skills!\n");

                bool isGameOn = true;

                do
                {
                    Console.Clear();
                    Console.WriteLine(@"What do you want to practice? Please select from down below:
                    A - Addition
                    S - Substraction
                    M - Multiplication
                    D - Division
                    V - View games
                    Q - Quit program");

                    var gameSelected = Console.ReadLine();

                    switch (gameSelected.Trim().ToLower())
                    {
                        case "a":
                            AdditionGame("Addition game");
                            break;
                        case "s":
                            SubstractionGame("Substraction game");
                            break;
                        case "m":
                            MultiplicationGame("Multipication game");
                            break;
                        case "d":
                            DivisionGame("Division game");
                            break;
                        case "v":
                            GetGames();
                            break;
                        case "q":
                            QuitGame();
                            isGameOn = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
                while (isGameOn);
            }
            void AdditionGame(string message)
            {

                var random = new Random();
                int firstNumber;
                int secondNumber;
                int score = 0;
                for (int i = 1; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    firstNumber = random.Next(0, 10);
                    secondNumber = random.Next(0, 10);

                    Console.WriteLine($"{firstNumber} + {secondNumber} = ?");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber + secondNumber)
                    {
                        Console.WriteLine("Correct answer! Next...");
                        score++;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"Wrong, the correct answer is: {firstNumber + secondNumber}. Next...");
                        Console.ReadKey();
                    }
                }
                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine($"Final score: {score}. Press any key to return to main menu...");
                AddToHistory(score, "Addition");
                Console.ReadKey();
            }
            void SubstractionGame(string message)
            {
                var random = new Random();
                int firstNumber;
                int secondNumber;
                int score = 0;
                for (int i = 1; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    firstNumber = random.Next(0, 10);
                    secondNumber = random.Next(0, 10);

                    Console.WriteLine($"{firstNumber} - {secondNumber} = ?");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber - secondNumber)
                    {
                        Console.WriteLine("Correct answer! Next...");
                        score++;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"Wrong, the correct answer is: {firstNumber - secondNumber}. Next...");
                        Console.ReadKey();
                    }
                }
                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine($"Final score: {score}. Press any key to return to main menu...");
                AddToHistory(score, "Substraction");

                Console.ReadKey();
            }
            void MultiplicationGame(string message)
            {
                var random = new Random();
                int firstNumber;
                int secondNumber;
                int score = 0;
                for (int i = 1; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    firstNumber = random.Next(0, 10);
                    secondNumber = random.Next(0, 10);

                    Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber * secondNumber)
                    {
                        Console.WriteLine("Correct answer! Next...");
                        score++;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"Wrong, the correct answer is: {firstNumber * secondNumber}. Next...");
                        Console.ReadKey();
                    }
                }
                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine($"Final score: {score}. Press any key to return to main menu...");
                AddToHistory(score, "Multiplication");

                Console.ReadKey();
            }
            void DivisionGame(string message)
            {
                int score = 0;
                for (int i = 1; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    var divisionNumbers = GetDivisionNumbers();
                    int firstNumber = divisionNumbers[0];
                    int secondNumber = divisionNumbers[1];

                    Console.WriteLine($"{firstNumber} / {secondNumber} = ?");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber / secondNumber)
                    {
                        Console.WriteLine("Correct answer! Next...");
                        score++;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"Wrong, the correct answer is: {firstNumber / secondNumber}. Next...");
                        Console.ReadKey();
                    }
                }
                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine($"Final score: {score}. Press any key to return to main menu...");
                AddToHistory(score, "Division");

                Console.ReadKey();
            }
            void QuitGame()
            {
                Console.Clear();
                Console.WriteLine("Goodbye!");
                Environment.Exit(1);
            }
            int[] GetDivisionNumbers()
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
            void GetGames()
            {
                Console.Clear();
                Console.WriteLine("-Game History-");
                foreach (var game in games)
                {
                    Console.WriteLine(game);
                }
                Console.WriteLine("--------------");
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
            void AddToHistory(int gameScore, string gameType)
            {
                games.Add($"{DateTime.Now} - {gameType} - {gameScore} points");
            }
        }
    }
}