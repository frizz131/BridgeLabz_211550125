using System;
public class Book
{
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    // Constructor to initialize Title and PublicationYear
    public Book(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
    }
}

public class Author : Book
{
    public string Name { get; set; }
    public string Bio { get; set; }
    public Author(string title, int publicationYear, string name, string bio)
        : base(title, publicationYear)
    {
        Name = name;
        Bio = bio;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo(); // Call the base class method to display book info
        Console.WriteLine($"Author Name: {Name}");
        Console.WriteLine($"Author Bio: {Bio}");
    }
}
public class Program
{
    public static void Main()
    {
        Author author = new Author("The Great Adventure", 2023, "John Doe", "John Doe is a prolific writer known for his adventurous novels.");
        author.DisplayInfo();
    }
}
