namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
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
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubstractionGame("Substraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multipication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "q":
                        Helpers.QuitGame();
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
    }
}
