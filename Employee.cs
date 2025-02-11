using System;
public class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }
    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Employee ID: {Id}");
        Console.WriteLine($"Employee Salary: {Salary:C}");
    }
}

public class Manager : Employee
{
    public int TeamSize { get; set; }
    public Manager(string name, int id, double salary, int teamSize)
        : base(name, id, salary)
    {
        TeamSize = teamSize;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Team Size: {TeamSize}");
    }
}

public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }
    public Developer(string name, int id, double salary, string programmingLanguage)
        : base(name, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails(); 
        Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
    }
}

// Define the Intern subclass
public class Intern : Employee
{
    public string InternshipDuration { get; set; }
    public Intern(string name, int id, double salary, string internshipDuration)
        : base(name, id, salary)
    {
        InternshipDuration = internshipDuration;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails(); 
        Console.WriteLine($"Internship Duration: {InternshipDuration}");
    }
}
public class Program
{
    public static void Main()
    {
        // Create instances of Manager, Developer, and Intern
        Employee manager = new Manager("Alice", 101, 90000, 10);
        Employee developer = new Developer("Bob", 102, 80000, "C#");
        Employee intern = new Intern("Charlie", 103, 20000, "6 months");

        // Display the details for each employee
        Console.WriteLine("Manager Details:");
        manager.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Developer Details:");
        developer.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Intern Details:");
        intern.DisplayDetails();
    }
}
