using static System.Formats.Asn1.AsnWriter;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            
            var date = DateTime.Now;
            
            string name = GetName();
            
            menu.ShowMenu(name, date);
            
            string GetName()
            {
                Console.WriteLine("Hello, \nPlease type your name:");
                var name = Console.ReadLine();
                Console.Clear();
                return name;
            }          
        }
    }
}