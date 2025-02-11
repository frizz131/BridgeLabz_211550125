using System;

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public abstract void MakeSound();
}
public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

public class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

public class Program
{
    public static void Main()
    {
        Animal myDog = new Dog("Buddy", 3);
        Animal myCat = new Cat("Whiskers", 2);
        Animal myBird = new Bird("Tweety", 1);
        myDog.MakeSound();  
        myCat.MakeSound();  
        myBird.MakeSound(); 
    }
}
