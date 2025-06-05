using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display application title
            Console.WriteLine("Car Insurance Application");

            // Ask user for their age and convert input to integer
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask if the user has had a DUI and convert to lowercase for consistency
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string answer = Console.ReadLine().ToLower();
            bool dui = answer == "yes";

            // Ask how many speeding tickets the user has
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Display the header for the result
            Console.WriteLine("Qualified for insurance?");

            // Logic: Must be over 15, have no DUI, and 3 or fewer tickets
            bool qualified = (age > 15) && !dui && (tickets <= 3);
            Console.WriteLine(qualified); // Output true or false

            // Keeps the console window open (optional)
            Console.ReadLine();
        }
    }
}
