namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();

            void Menu()
            {
                Console.WriteLine("Hello, \nPlease type your name:");
                var name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Hello {name}. It's time to work on your math skills!\n");
                Console.WriteLine(@"What do you want to practise? Please select from down below:
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
            }
            void SubstractionGame(string message)
            {
                Console.Clear();
                Console.WriteLine(message);
            }
            void MultiplicationGame(string message)
            {
                Console.Clear();
                Console.WriteLine(message);
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