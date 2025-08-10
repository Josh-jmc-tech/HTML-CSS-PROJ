

namespace MathOperationApp
{
    // This is the class that contains the math operation method
    class MathOperation
    {
        // This void method takes two integers as parameters
        public void PerformOperation(int number1, int number2)
        {
            // Perform a math operation on the first integer (e.g., multiply by 2)
            int result = number1 * 2;

            // Display the result of the math operation
            Console.WriteLine("Result of math operation on first number: " + result);

            // Display the second integer as it is
            Console.WriteLine("Second number (displayed only): " + number2);
        }
    }

    // This is the main class where the program execution starts
    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class
            MathOperation operation = new MathOperation();

            // Call the method with two integers, passing values directly
            operation.PerformOperation(5, 10);

            // Call the method again, this time using named parameters
            operation.PerformOperation(number1: 8, number2: 15);

            // Pause the console so that output stays on screen
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
