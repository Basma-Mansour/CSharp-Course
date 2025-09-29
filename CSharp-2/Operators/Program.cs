using System;

namespace EmployeeEqualityApp4
{
    // Represents a company employee
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload == operator to compare only IDs
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, they are equal
            if (emp1 is null && emp2 is null) return true;

            // If one is null, they are not equal
            if (emp1 is null || emp2 is null) return false;

            // Compare based on Id
            return emp1.Id == emp2.Id;
        }

        // Overload != operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals
        public override bool Equals(object obj)
        {
            var other = obj as Employee;
            return this == other;
        }

        // Override GetHashCode
        public override int GetHashCode()
        {
            return Id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize two employees with different Ids
            var emp1 = new Employee { Id = 1, FirstName = "Basma", LastName = "Mansour" };
            var emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Marry" };

            // Check equality using operator overload
            Console.WriteLine($"Is emp1 equal to emp2? {emp1 == emp2}");
            Console.WriteLine($"Is emp1 not equal to emp2? {emp1 != emp2}");
        }
    }
}
