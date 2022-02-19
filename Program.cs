using System;
using System.Threading;

namespace Rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Loading Game");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("Hello and welcome to The adventuders of Campus Allegro");
            Console.WriteLine("");




            // Charachter creation.
            Console.WriteLine("What is your name?");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Choose you Proffession: 1.CSharp Warrior 2.Meme Knight 3.Code Hunter 4.String Wizzard");
            string proffesionTemp = "";
            while (true)
            {
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                    if (userInput > 4 || userInput < 1)
                    {
                        Console.WriteLine("Wrong number");
                    }
                    if (userInput == 1)
                    {
                        proffesionTemp = "CSharp Warrior";
                        break;
                    }
                    if (userInput == 2)
                    {
                        proffesionTemp = "Meme Knight";
                        break;
                    }
                    if (userInput == 3)
                    {
                        proffesionTemp = "Code Hunter";
                        break;
                    }
                    if (userInput == 4)
                    {
                        proffesionTemp = "CSharp Warrior";
                        break;
                    }
                }

                catch (Exception)
                {
                    Console.ResetColor();
                    Console.WriteLine("Wrong input. Use a number!");
                }
            }
            Player character = new Player(nameInput, proffesionTemp);
            LevelOne lvl1 = new LevelOne(character);


            //GAME STARTS
            lvl1.Start();


        }
    }
}
