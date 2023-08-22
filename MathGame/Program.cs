using static System.Formats.Asn1.AsnWriter;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            
            var date = DateTime.Now;
            
            string name = Helpers.GetName();
            
            menu.ShowMenu(name, date);
            
        }
    }
}