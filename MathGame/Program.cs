namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
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
                Console.WriteLine(@"What do you want to practice? Please select from down below:
            A - Addition
            S - Substraction
            M - Multiplication
            D - Division
            Q - Quit program");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "a":
                        AdditionGame("Addition game selected");
                        break;
                    case "s":
                        SubstractionGame("Substraction game selected");
                        break;
                    case "m":
                        MultiplicationGame("Multipication game selected");
                        break;
                    case "d":
                        DivisionGame("Division game selected");
                        break;
                    case "q":
                        QuitGame();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            void AdditionGame(string message)
            {
                Console.Clear();
                Console.WriteLine(message);

                var random = new Random();
                int firstNumber;
                int secondNumber;
                int score = 0;
                for (int i = 1 ; i < 5; i++)
                {
                    firstNumber = random.Next(0, 10);
                    secondNumber = random.Next(0, 10);

                    Console.WriteLine($"{firstNumber} + {secondNumber} = ?");
                    var result = Console.ReadLine();
                    
                    if (int.Parse(result) == firstNumber + secondNumber)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong, the correct answer is: {firstNumber + secondNumber}");
                    }
                }
                Console.WriteLine($"Final score: {score}");
            }
            void SubstractionGame(string message)
            {
                Console.Clear();
                Console.WriteLine(message);

                var random = new Random();
                int firstNumber;
                int secondNumber;
                int score = 0;
                for (int i = 1; i < 5; i++)
                {
                    firstNumber = random.Next(0, 10);
                    secondNumber = random.Next(0, 10);

                    Console.WriteLine($"{firstNumber} - {secondNumber} = ?");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber - secondNumber)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong, the correct answer is: {firstNumber - secondNumber}");
                    }
                }
                Console.WriteLine($"Final score: {score}");
            }
            void MultiplicationGame(string message)
            {
                Console.Clear();
                Console.WriteLine(message);

                var random = new Random();
                int firstNumber;
                int secondNumber;
                int score = 0;
                for (int i = 1; i < 5; i++)
                {
                    firstNumber = random.Next(0, 10);
                    secondNumber = random.Next(0, 10);

                    Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber * secondNumber)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong, the correct answer is: {firstNumber * secondNumber}");
                    }
                }
                Console.WriteLine($"Final score: {score}");
            }
            void DivisionGame(string message)
            {
                Console.Clear();
                Console.WriteLine(message);
            }
            void QuitGame()
            {
                Console.Clear();
                Console.WriteLine("Goodbye!");
                Environment.Exit(1);
            }

        }
    }
}