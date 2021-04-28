using System;
using System.Collections.Generic;

namespace Deliverable2
{
    class Program
    {
       

        static void Main(string[] args)
        {


         Console.WriteLine("Hello");

            double d1 = 1;
            double d2 = 1;
            double d3 = 1;


            while (true)
            {
                Console.WriteLine("What would you like to say to the bot?");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "hello" && d1 == 1)
                {
                    Console.WriteLine("Hi good to see you");
                    d1++;
                }
                else if (userInput == "hello there" && d2 == 1)
                {
                    Console.WriteLine("General Kenobi");
                    d2++;
                }
                else if (userInput == "sup" && d3 == 1)
                {
                    Console.WriteLine("I am good");
                    d3++;
                }
                else if (userInput == "bye")
                {
                    Console.WriteLine("Thank you for using goodbye");
                    return;
                }
                else if (d1 > 1)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }
                else if (d2 > 1)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }
                else if (d3 > 1)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }
























            }
        }
    }
}
