using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class TestIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a Language:");

            // Take Language Choice from User in input
            string input = Console.ReadLine();

            // Information is displayed based on input comparison
            if (input.Equals("VB"))
            {
                Console.WriteLine("VB .NET: OOP, Multithreading and more!");
            }
            else if (input.Equals("C#"))
            {
                Console.WriteLine("Good choice, C# is a fine language.");
            }
            else
            {
                Console.WriteLine("Well...good luck with that!");
            }

            // console remain on screen until user presses any character
            Console.ReadLine();
        }
    }
}
