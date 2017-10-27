using System;

namespace GCLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino! What is your name? ");
            string userName = Console.ReadLine();

            while (true) //to make sure the user wants to play or exit 
            {
                //Ask user if they want to play
                Console.WriteLine($"{userName} would you like to roll some dice (y/n)? ");
                bool Casino = GetYesorNo();
                if (Casino == false)
                {
                    return;
                }

                while (Casino)
                {
                    //get prompt user for input for sides on dice
                    Console.Write("Entering the Dice Roller!\nPlease enter the number of sides on your dice: ");

                    bool repeat = true;

                    //get valid input
                    int input = GetInt(userName);

                    while (repeat)
                    {

                        //Loop for rolling selected dice must exit to choose new dice
                        Random generator = new Random();
                        int diceRoll1 = generator.Next(input) + 1;
                        int diceRoll2 = generator.Next(input) + 1;
                        Console.WriteLine(diceRoll1 + "\n");
                        Console.WriteLine(diceRoll2 + "\n");

                        Console.WriteLine($"You rolled a {diceRoll1} and a {diceRoll2} on die with {input} sides!");

                        //Prompt user for another roll
                        Console.Write($"{userName} you like to roll the same dice again (y/n)? ");
                        repeat = GetYesorNo();
                        Casino = false;
                    }

                }
            }
        }

        private static bool GetYesorNo()
        {
            bool valid = true;
            bool repeat = true;
            while (valid)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "y" || answer == "yes")
                {
                    valid = false;
                    repeat = true;
                }
                else if (answer == "n" || answer == "no")

                {
                    valid = false;
                    repeat = false;
                }
                else
                {
                    Console.Write("Did not enter a valid input. Please enter (y/n): ");
                }
            }
            return repeat;
        }

        private static int GetInt(string name)
        {
            bool valid = false;
            int input = 0;

            while (!valid)
            {

                string sides = Console.ReadLine();
                valid = int.TryParse(sides, out input);
            }
            if (!valid)
            {
                Console.WriteLine($"{name}... You didn't enter valid input. Try again: ");
            }
            return input;
        }
    }
}