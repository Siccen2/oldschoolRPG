using System;
using System.Threading;

namespace Rpg
{
    public class LevelOne 
    {  
        public LevelOne()
        {

        } 
        public static void Start()
        {
        Console.WriteLine("You wake up with a mind blowing headache, the last you remember is sitting at home and writing a lot of code in some weird language called c#.");
            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            //QUESTION           
            Console.WriteLine("1. Look Around. 2. What the hell is goin on? I dont want to be here!");
            Console.ResetColor();

            while (true)
            {
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                    if(userInput > 2 || userInput < 1)
                    {
                        Console.WriteLine("Wrong number!");
                    }
                    if (userInput == 2)
                    {
                        Console.WriteLine("GAME OVER!");
                        Environment.Exit(0);
                    }
                    if (userInput == 1)
                    {
                        Console.WriteLine("You look aournd, it's dark but you se some light far away.");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.ResetColor();
                    Console.WriteLine("Wrong input. Use a number!");
                }
            }
            Thread.Sleep(2000);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            //QUESTION 
            Console.WriteLine("1. Go to the light. 2. RUN AWAY!");
            Console.ResetColor();
            
            while (true)
            {
                try
                {
                    int userInput2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                    if(userInput2 > 2 || userInput2 < 1)
                    {
                        Console.WriteLine("Wrong number!");
                    }
                    if (userInput2 == 2)
                    {
                        Console.WriteLine("GAME OVER!");
                        Environment.Exit(0);
                    }
                    if (userInput2 == 1)
                    {
                        Console.WriteLine("You approach the light and see a small house.");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.ResetColor();
                    Console.WriteLine("Wrong input. Use a number!");
                }
            }

            // INSIDE HOUSE
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("A man opens the door. Welcome Sir, we have been waiting on you...... Tell us your name!");
            Console.Write("Enter you name: ");
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Come inside, quick before some one sees you " + "player.name" +"!" + " We have a quest for you Sir.");
        
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.Write("Our beloved daughter has been kidnapped by the EVIL cave troll");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" HEIKKI! ");
            Console.ResetColor();
            Console.WriteLine("We need you to free her nobel knight");
            Console.WriteLine("");
            
        }
    }
}    
