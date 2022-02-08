using System;
using System.Threading;

namespace Rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Hello and welcome to The adventuders in Campus Allegro");
            Console.WriteLine("Loading...");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(4000);

            Console.WriteLine("You wake up with a mind blowing headache, the last you remember is sitting at home and writing a lot of code in some weird language called c#.");
            Console.WriteLine("");
            Console.WriteLine("What will you do? (1.Look Around. 2.You go back to sleep.)");
            Console.WriteLine("");
            string userInput = Console.ReadLine();
            if (userInput == "2")
            {
                Environment.Exit(0);
            }
            if (userInput == "1")
            {
                Console.WriteLine("You look aournd, it's dark but you se some light far away."); 
            }
            Console.WriteLine("What will you do? (1.Look Around. 2.You go back to sleep.)");


            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + name + "");
            Console.WriteLine("");

        }
    }
}
