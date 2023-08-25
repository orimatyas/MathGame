using System.Diagnostics;
using static MathGame.Model.Game;
namespace MathGame
{
    internal class GameEngine
    {
        Stopwatch stopwatch = new Stopwatch();
        internal void AdditionGame(string message)
        {

            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < Helpers.questionNum; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(0, Helpers.difficultyCap);
                secondNumber = random.Next(0, Helpers.difficultyCap);

                Console.WriteLine($"{firstNumber} + {secondNumber} = ?");
                stopwatch.Start();
                var result = Console.ReadLine();
                stopwatch.Stop();
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
            TimeSpan elapsed = stopwatch.Elapsed;
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine($"Final score: {score}. \nFinal time: {elapsed.TotalSeconds} seconds. \nPress any key to return to main menu...");
            Helpers.AddToHistory(score, GameType.Addition, elapsed);
            stopwatch.Reset();
            Console.ReadKey();
            Console.Clear();
        }

        internal void SubtractionGame(string message)
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < Helpers.questionNum; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(0, Helpers.difficultyCap);
                secondNumber = random.Next(0, Helpers.difficultyCap);

                Console.WriteLine($"{firstNumber} - {secondNumber} = ?");
                stopwatch.Start();
                var result = Console.ReadLine();
                stopwatch.Stop();
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
            TimeSpan elapsed = stopwatch.Elapsed;
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine($"Final score: {score}. \nFinal time: {elapsed.TotalSeconds} seconds. \nPress any key to return to main menu...");
            Helpers.AddToHistory(score, GameType.Subtraction, elapsed);
            stopwatch.Reset();
            Console.ReadKey();
            Console.Clear();
        }

        internal void MultiplicationGame(string message)
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < Helpers.questionNum; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(0, Helpers.difficultyCap);
                secondNumber = random.Next(0, Helpers.difficultyCap);

                Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
                stopwatch.Start();
                var result = Console.ReadLine();
                stopwatch.Stop();
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
            TimeSpan elapsed = stopwatch.Elapsed;
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine($"Final score: {score}. \nFinal time: {elapsed.TotalSeconds} seconds. \nPress any key to return to main menu...");
            Helpers.AddToHistory(score, GameType.Multiplication, elapsed);
            stopwatch.Reset();
            Console.ReadKey();
            Console.Clear();
        }

        internal void DivisionGame(string message)
        {
            int score = 0;
            for (int i = 0; i < Helpers.questionNum; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber} = ?");
                stopwatch.Start();
                var result = Console.ReadLine();
                stopwatch.Stop();
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
            TimeSpan elapsed = stopwatch.Elapsed;
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine($"Final score: {score}. \nFinal time: {elapsed.TotalSeconds} seconds. \nPress any key to return to main menu...");
            Helpers.AddToHistory(score, GameType.Division, elapsed);
            stopwatch.Reset();
            Console.ReadKey();
            Console.Clear();
        }

        internal void RandomGame(string message)
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int randomGame;
            int score = 0;
            
            for (int i = 0; i < Helpers.questionNum; i++)
            {
                randomGame = random.Next(1, 4);
                if (randomGame == 1)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    firstNumber = random.Next(0, Helpers.difficultyCap);
                    secondNumber = random.Next(0, Helpers.difficultyCap);

                    Console.WriteLine($"{firstNumber} + {secondNumber} = ?");
                    stopwatch.Start();
                    var result = Console.ReadLine();
                    stopwatch.Stop();
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
                else if (randomGame == 2)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    firstNumber = random.Next(0, Helpers.difficultyCap);
                    secondNumber = random.Next(0, Helpers.difficultyCap);

                    Console.WriteLine($"{firstNumber} - {secondNumber} = ?");
                    stopwatch.Start();
                    var result = Console.ReadLine();
                    stopwatch.Stop();
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
                else if (randomGame == 3)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    firstNumber = random.Next(0, Helpers.difficultyCap);
                    secondNumber = random.Next(0, Helpers.difficultyCap);

                    Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
                    stopwatch.Start();
                    var result = Console.ReadLine();
                    stopwatch.Stop();
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
                else if (randomGame == 4)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    var divisionNumbers = Helpers.GetDivisionNumbers();
                    int fstNumber = divisionNumbers[0];
                    int sndNumber = divisionNumbers[1];

                    Console.WriteLine($"{fstNumber} / {sndNumber} = ?");
                    stopwatch.Start();
                    var result = Console.ReadLine();
                    stopwatch.Stop();
                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == fstNumber / sndNumber)
                    {
                        Console.WriteLine("Correct answer! Next...");
                        score++;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"Wrong, the correct answer is: {fstNumber / sndNumber}. Next...");
                        Console.ReadKey();
                    }
                }
            }
            TimeSpan elapsed = stopwatch.Elapsed;
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine($"Final score: {score}. \nFinal time: {elapsed.TotalSeconds} seconds. \nPress any key to return to main menu...");
            Helpers.AddToHistory(score, GameType.Addition, elapsed);
            stopwatch.Reset();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
