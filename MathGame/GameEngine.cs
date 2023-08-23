using static MathGame.Model.Game;
namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {

            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            int num = Helpers.questionNum;
            for (int i = 0; i < num; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(0, Helpers.difficultyCap);
                secondNumber = random.Next(0, Helpers.difficultyCap);

                Console.WriteLine($"{firstNumber} + {secondNumber} = ?");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

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
            Console.WriteLine($"Final score: {score}. \nPress any key to return to main menu...");
            Helpers.AddToHistory(score, GameType.Addition);
            Console.ReadKey();
            Console.Clear();
        }

        internal void SubtractionGame(string message)
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            int num = Helpers.questionNum;
            for (int i = 0; i < num; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(0, Helpers.difficultyCap);
                secondNumber = random.Next(0, Helpers.difficultyCap);

                Console.WriteLine($"{firstNumber} - {secondNumber} = ?");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

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
            Console.WriteLine($"Final score: {score}. \nPress any key to return to main menu...");
            Helpers.AddToHistory(score, GameType.Subtraction);
            Console.ReadKey();
            Console.Clear();
        }

        internal void MultiplicationGame(string message)
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            int num = Helpers.questionNum;
            for (int i = 0; i < num; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(0, Helpers.difficultyCap);
                secondNumber = random.Next(0, Helpers.difficultyCap);

                Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

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
            Console.WriteLine($"Final score: {score}. \nPress any key to return to main menu...");
            Helpers.AddToHistory(score, GameType.Multiplication);
            Console.ReadKey();
            Console.Clear();
        }

        internal void DivisionGame(string message)
        {
            int score = 0;
            int num = Helpers.questionNum;
            for (int i = 0; i < num; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber} = ?");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

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
            Console.WriteLine($"Final score: {score}. \nPress any key to return to main menu...");
            Helpers.AddToHistory(score, GameType.Division);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
