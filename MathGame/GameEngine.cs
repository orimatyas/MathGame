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
            Console.WriteLine($"Final score: {score}. \nPress any key to return to main menu...");
            Helpers.AddToHistory(score, "Addition");
            Console.ReadKey();
        }
        internal void SubstractionGame(string message)
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
            Console.WriteLine($"Final score: {score}. \nPress any key to return to main menu...");
            Helpers.AddToHistory(score, "Substraction");

            Console.ReadKey();
        }
        internal void MultiplicationGame(string message)
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
            Console.WriteLine($"Final score: {score}. \nPress any key to return to main menu...");
            Helpers.AddToHistory(score, "Multiplication");

            Console.ReadKey();
        }
        internal void DivisionGame(string message)
        {
            int score = 0;
            for (int i = 1; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
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
            Console.WriteLine($"Final score: {score}. \nPress any key to return to main menu...");
            Helpers.AddToHistory(score, "Division");

            Console.ReadKey();
        }
    }
}
