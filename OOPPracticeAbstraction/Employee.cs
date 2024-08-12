using System;

namespace OOPPracticeAbstraction
{
    // Abstract base class representing an employee
    public abstract class Employee
    {
        // Properties to store the name, surname, and department of an employee
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Departmant { get; set; }

        // Abstract method that must be overridden in derived classes
        public abstract void Mission();
    }

    // Concrete class representing a Software Developer
    public class SoftwareDeveloper : Employee
    {
        // Override the abstract method to define the mission of a Software Developer
        public override void Mission()
        {
            Console.WriteLine("I am working as a Software Developer.");
        }
    }

    // Concrete class representing a Project Manager
    public class ProjectManager : Employee
    {
        // Override the abstract method to define the mission of a Project Manager
        public override void Mission()
        {
            Console.WriteLine("I am working as a Project Manager.");
        }
    }

    // Concrete class representing a Sales Representative
    public class SalesRepresentative : Employee
    {
        // Override the abstract method to define the mission of a Sales Representative
        public override void Mission()
        {
            Console.WriteLine("I am working as a Sales representative.");
        }
    }
}
