using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if weight is over the limit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program
        }

        // Prompt user for package width
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt user for package height
        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt user for package length
        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if the total of dimensions is over the limit
        if ((width + height + length) > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program
        }

        // Calculate the shipping quote
        double quote = (width * height * length * weight) / 100;

        // Display the result as a dollar amount
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
        Console.WriteLine("Thank you!");
    }
}
