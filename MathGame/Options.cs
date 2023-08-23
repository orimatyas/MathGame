namespace MathGame
{
    internal class Options
    {
        internal void OptionsMenu()
        {
            bool optionsOn = true;
            do
            {
                Console.Clear();
                Console.WriteLine(@"Options:
D - Difficulty
N - Number of questions
C - Color of background

Press Enter to return to main menu");

                var optionSelected = Console.ReadLine();

                switch (optionSelected.Trim().ToLower())
                {
                    case "d":
                        Console.Clear();
                        Helpers.DifficultyChoice();
                        break;
                    case "n":
                        Console.Clear();
                        Helpers.QuestionNumbers();
                        break;
                    case "c":
                        Console.Clear();
                        Console.WriteLine("Select the color of the console");
                        Console.WriteLine(@"1 - Black
2 - White
3 - Blue
4 - Red
5 - Yellow");
                        Helpers.SetColors();
                        break;
                    default:
                        optionsOn = false;
                        Console.Clear();
                        break;

                }
            }
            while (optionsOn);
        }
    }
}
