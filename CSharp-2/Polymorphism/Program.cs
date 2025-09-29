using System;

namespace QuittableApp
{
    // Interface defining the Quit method
    public interface IQuittable
    {
        void Quit(); // Required method for quitting
    }

    // Employee class implementing the IQuittable interface
    public class Employee : IQuittable
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        // Quit implementation simulating HR system removal
        public void Quit()
        {
            Console.WriteLine($"Removing employee {FullName} (ID: {Id}) from HR records...");
            Console.WriteLine("Sending final paycheck...");
            Console.WriteLine("Deactivating system access...");
            Console.WriteLine("Process completed.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an employee instance
            var emp = new Employee { Id = 888, FullName = "Basma Mansour" };

            // Assign to interface for polymorphism
            IQuittable quitter = emp;

            // Call the Quit method using interface type
            quitter.Quit(); // Simulates a full HR offboarding process
        }
    }
}
