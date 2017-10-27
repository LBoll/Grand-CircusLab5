using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            string userName;
            while (repeat)
            {
                Console.WriteLine("Welcome to the Grand Circus Casino! Let's start with your name: ");
                userName = Console.ReadLine();

                Console.Write($"{userName}, would you like to roll the dice? (y/n) ");

                bool success = true;
                while (success)
                {
                    string answer = Console.ReadLine();
                    if (answer == "y" || answer == "Y" )
                    {
                        repeat = true;
                        success = false;
                    }
                    else if (answer == "n" || answer == "N")
                    {
                        Console.Write($"Come on, {userName}! Gambling is fun!(: ");
                        success = true;

                        string answer2 = Console.ReadLine();
                        if (answer2 == "y" || answer2 == "Y")
                        {
                            repeat = true;
                            success = false;
                        }
                        else if (answer2 == "n" || answer2 == "N" || answer2 == "no" || answer2 == "No")
                        {
                            Console.WriteLine("I see it was a waste of time to even ask for your name. Good riddance!\n" );
                            success = true;
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"Come on {userName}, it is a yes or no question. ");
                            Console.WriteLine("Please enter a valid input! ");
                            success = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid input! ");
                        success = true;
                    }
                }

                Console.WriteLine($"Let us begin! {userName}, how many sides does the dice have? ");
                return;

            }
            
        }
    }
}
