using System;

namespace InterfacePolymorphismApp
{
    // This is the interface that defines a contract for any class that implements it.
    // It declares a method named Quit, which has no return type (void).
    interface IQuittable
    {
        void Quit();
    }

    // This is the Employee class.
    // It implements the IQuittable interface, meaning it must define the Quit() method.
    class Employee : IQuittable
    {
        // You can also add properties to Employee if needed
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize Employee properties (optional)
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Implementation of the Quit() method from IQuittable interface
        public void Quit()
        {
            // Here we define the behavior when an employee quits
            Console.WriteLine($"{FirstName} {LastName} has quit the company.");
        }
    }

    // Main class where the program starts
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee and assign it to a variable of type IQuittable
            // This is an example of polymorphism — using an interface type to refer to an object.
            IQuittable quittableEmployee = new Employee("Jane", "Doe");

            // Call the Quit() method using the interface-typed object
            // The method that runs is the one defined in the Employee class.
            quittableEmployee.Quit();

            // Keep the console window open until a key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
