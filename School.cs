using System;
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }

    public virtual void DisplayRole()
    {
        Console.WriteLine("Role: General Person");
    }
}
public class Teacher : Person
{
    public string Subject { get; set; }
    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Teacher");
        Console.WriteLine($"Subject: {Subject}");
    }
}

public class Student : Person
{
    public string Grade { get; set; }
    public Student(string name, int age, string grade)
        : base(name, age)
    {
        Grade = grade;
    }
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Student");
        Console.WriteLine($"Grade: {Grade}");
    }
}
public class Staff : Person
{
    public string Position { get; set; }
    public Staff(string name, int age, string position)
        : base(name, age)
    {
        Position = position;
    }
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Staff");
        Console.WriteLine($"Position: {Position}");
    }
}
public class Program
{
    public static void Main()
    {
        Teacher teacher = new Teacher("Mr. Smith", 40, "Math");
        Student student = new Student("Alice Johnson", 16, "10th Grade");
        Staff staff = new Staff("Mrs. Lee", 50, "Janitor");
        Console.WriteLine("Teacher Details:");
        teacher.DisplayInfo();
        teacher.DisplayRole();

        Console.WriteLine("\nStudent Details:");
        student.DisplayInfo();
        student.DisplayRole();

        Console.WriteLine("\nStaff Details:");
        staff.DisplayInfo();
        staff.DisplayRole();
    }
}
