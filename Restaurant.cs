using System;
public class Person
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {Id}");
    }
}
public interface Worker
{
    void PerformDuties();
}
public class Chef : Person, Worker
{
    public string CuisineSpecialty { get; set; }
    public Chef(string name, int id, string cuisineSpecialty)
        : base(name, id)
    {
        CuisineSpecialty = cuisineSpecialty;
    }
    public void PerformDuties()
    {
        Console.WriteLine($"{Name} is cooking {CuisineSpecialty}.");
    }
    public void DisplaySpecialty()
    {
        Console.WriteLine($"Cuisine Specialty: {CuisineSpecialty}");
    }
}
public class Waiter : Person, Worker
{
    public string Section { get; set; }
    public Waiter(string name, int id, string section)
        : base(name, id)
    {
        Section = section;
    }
    public void PerformDuties()
    {
        Console.WriteLine($"{Name} is serving customers in section {Section}.");
    }
    public void DisplaySection()
    {
        Console.WriteLine($"Serving in section: {Section}");
    }
}

public class Program
{
    public static void Main()
    {
        Chef chef = new Chef("Chef Gordon", 101, "French Cuisine");
        chef.DisplayInfo();
        chef.DisplaySpecialty();
        chef.PerformDuties();
        Waiter waiter = new Waiter("John", 102, "A1");
        waiter.DisplayInfo();
        waiter.DisplaySection();
        waiter.PerformDuties();
    }
}
