namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();

        Options optionsMenu = new();

        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine($"Hello {name}. Today it's {date}. It's time to work on your math skills!\n");

            bool isGameOn = true;

            do
            {
                Console.WriteLine(@"What do you want to practice? Please select from down below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
R - Random
V - View games
O - Options
Q - Quit program");

                var gameSelected = Console.ReadLine();
                Console.Clear();
                switch (gameSelected.Trim().ToLower())
                {
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multipication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;
                    case "r":
                        gameEngine.RandomGame("Random game");
                        break;
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "o":
                        optionsMenu.OptionsMenu();
                        break;
                    case "q":
                        Helpers.QuitGame();
                        isGameOn = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            while (isGameOn);
        }
    }
}
