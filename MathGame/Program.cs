namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, \nPlease type your name:");
            var name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hello {name}. It's great, that you are working on your math skills!\n");
            Console.WriteLine(@"What game would you like to try? Please select from down below:
            A - Addition
            S - Substraction
            M - Multiplication
            D - Division
            Q - Quit program");

            var gameSelected = Console.ReadLine();

            if (gameSelected.Trim().ToLower() == "a")
            {
                AdditionGame();
            }
            else if (gameSelected.Trim().ToLower() == "s")
            {
                SubstractionGame();
            }
            else if (gameSelected.Trim().ToLower() == "m")
            {
                MultiplicationGame();
            }
            else if (gameSelected.Trim().ToLower() == "d")
            {
                DivisionGame();
            }
            else if (gameSelected.Trim().ToLower() == "q")
            {
                QuitGame();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input!");
                Console.WriteLine(@"Please choose from the options presented below:
                A - Addition
                S - Substraction
                M - Multiplication
                D - Division
                Q - Quit program");
            }

            

            void AdditionGame()
            {
                Console.Clear();
                Console.WriteLine("Addition game selected");
            }
            void SubstractionGame()
            {
                Console.Clear();
                Console.WriteLine("Substraction game selected");
            }
            void MultiplicationGame()
            {
                Console.Clear();
                Console.WriteLine("Multiplication game selected");
            }
            void DivisionGame()
            {
                Console.Clear();
                Console.WriteLine("Division game selected");
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