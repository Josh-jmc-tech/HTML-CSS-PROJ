using System;

namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first employee object
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "Alice",
                LastName = "Johnson"
            };

            // Create the second employee object
            Employee employee2 = new Employee()
            {
                Id = 2,
                FirstName = "Bob",
                LastName = "Smith"
            };

            // Compare the two employee objects using the overloaded == operator
            if (employee1 == employee2)
            {
                Console.WriteLine("employee1 and employee2 are equal (same Id).");
            }
            else
            {
                Console.WriteLine("employee1 and employee2 are NOT equal (different Ids).");
            }

            // Change employee2 Id to match employee1's Id
            employee2.Id = 1;

            // Compare again after changing the Id
            if (employee1 == employee2)
            {
                Console.WriteLine("After changing Id, employee1 and employee2 are now equal.");
            }
            else
            {
                Console.WriteLine("After changing Id, employee1 and employee2 are still NOT equal.");
            }

            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
