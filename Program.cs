using System;
using System.Threading;

namespace Rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Hello and welcome to The adventuders of Campus Allegro");
            Console.WriteLine("");
            Console.WriteLine("Loading Game");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            //GAME STARTS
            Console.WriteLine("What is your name?");
            string nameInput = Console.ReadLine();
            Player playerInfo = new Player(nameInput);
            
            LevelOne.Start(playerInfo);
            

        }
    }
}
