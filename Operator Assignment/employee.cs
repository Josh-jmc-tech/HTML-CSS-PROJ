using System;

namespace EmployeeComparisonApp
{
    // Define the Employee class with Id, FirstName, and LastName
    public class Employee
    {
        // Employee Id property
        public int Id { get; set; }

        // Employee First Name
        public string FirstName { get; set; }

        // Employee Last Name
        public string LastName { get; set; }

        // Overload the == operator to compare Employees by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check for null values to avoid NullReferenceException
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare the Ids of both Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (must be paired with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2); // Use the overloaded == operator
        }

        // Override Equals method for proper equality comparison
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee and compare Ids
            return obj is Employee employee && this.Id == employee.Id;
        }

        // Override GetHashCode for consistency with Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
