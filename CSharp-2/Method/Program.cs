using System;

namespace DividerApp
{
    // Class that performs division and comparison between numbers
    class Divider
    {
        // Method divides the first number by 2 and compares it with the second number
        public void Evaluate(int numerator, int compareTo)
        {
            double half = numerator / 2.0; // Divide first number by 2 (float division)
            Console.WriteLine("Half of the first number: " + half); // Display the result

            // Compare the second number with the result of the division
            string comparison = (half > compareTo) ? "greater than" :
                                (half < compareTo) ? "less than" : "equal to";
            Console.WriteLine("Half of the first number is " + comparison + " the second number (" + compareTo + ").");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Divider class
            Divider divider = new Divider();

            // Call method using positional parameters
            divider.Evaluate(10, 6);

            // Call method using named parameters
            divider.Evaluate(compareTo: 5, numerator: 8);
        }
    }
}
