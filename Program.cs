using System;

namespace Mission_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int rolls = 0;
            DiceFunctions df;

            // Get throw number
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");
            input = Console.ReadLine();
            rolls = Convert.ToInt32(input);

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + input + ".\n");

            df = new DiceFunctions();
            df.RollDice(rolls);

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!\n");

            
        }
    }
}

