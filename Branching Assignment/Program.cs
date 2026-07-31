using System;

class Program
{
    static void Main()
    {
        // 1. Display the mandatory welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // 2. Prompt the user for the package weight
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine());

        // 3. Check if the weight is too heavy (greater than 50)
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Terminate the program
        }

        // 4. Prompt the user for the package dimensions (width, height, length)
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // 5. Check if the sum of the dimensions is greater than 50
        double totalDimensions = width + height + length;
        if (totalDimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Terminate the program
        }

        // 6. Calculate the shipping quote:
        // Multiply height, width, and length, then multiply by weight, then divide by 100
        double quote = (height * width * length * weight) / 100;

        // 7. Display the final quote formatted as a currency (dollar amount) and thank the user
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}
