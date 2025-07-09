using System;

class Program
{
    const double MAX_WEIGHT = 50.0;
    const double MAX_DIMENSION_TOTAL = 50.0;
    const double QUOTE_DIVISOR = 100.0;

    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        try
        {
            // Weight input
            Console.Write("Please enter the package weight (in pounds):\n");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight <= 0)
            {
                Console.WriteLine("Weight must be greater than zero.");
                return;
            }
            if (weight > MAX_WEIGHT)
            {
                Console.WriteLine($"Package too heavy (>{MAX_WEIGHT} pounds) to be shipped via Package Express. Have a good day.");
                return;
            }

            // Dimensions input
            Console.Write("Please enter the package width (in inches):\n");
            double width = Convert.ToDouble(Console.ReadLine());
            if (width <= 0)
            {
                Console.WriteLine("Width must be greater than zero.");
                return;
            }

            Console.Write("Please enter the package height (in inches):\n");
            double height = Convert.ToDouble(Console.ReadLine());
            if (height <= 0)
            {
                Console.WriteLine("Height must be greater than zero.");
                return;
            }

            Console.Write("Please enter the package length (in inches):\n");
            double length = Convert.ToDouble(Console.ReadLine());
            if (length <= 0)
            {
                Console.WriteLine("Length must be greater than zero.");
                return;
            }

            // Check total dimensions
            double dimensionTotal = width + height + length;
            if (dimensionTotal > MAX_DIMENSION_TOTAL)
            {
                Console.WriteLine($"Package too large (total dimensions > {MAX_DIMENSION_TOTAL} inches) to be shipped via Package Express.");
                return;
            }

            // Quote calculation
            double volume = width * height * length;
            double quote = (volume * weight) / QUOTE_DIVISOR;
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values only for weight and dimensions.");
        }
    }
}
