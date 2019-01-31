using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string input = Console.ReadLine();

            try
            {
                Console.WriteLine("Hello " + input + "!");
                Console.WriteLine("Press any key to continue . . . ");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("An error has occured.");
                Console.ReadKey(true);
            }
        }
    }
}
