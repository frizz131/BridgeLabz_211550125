using System;
public class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; } 
    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }
    public virtual void DisplayCourseInfo()
    {
        Console.WriteLine($"Course Name: {CourseName}");
        Console.WriteLine($"Duration: {Duration} hours");
    }
}
public class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }
    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo(); 
        Console.WriteLine($"Platform: {Platform}");
        Console.WriteLine($"Is Recorded: {(IsRecorded ? "Yes" : "No")}");
    }
}
public class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; }
    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }
    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        Console.WriteLine($"Fee: ${Fee}");
        Console.WriteLine($"Discount: {Discount}%");
        Console.WriteLine($"Discounted Fee: ${Fee * (1 - Discount / 100)}");
    }
}
public class Program
{
    public static void Main()
    {
        PaidOnlineCourse paidCourse = new PaidOnlineCourse("Advanced C# Programming", 40, "Udemy", true, 99.99, 20);
        Console.WriteLine("Paid Online Course Details:");
        paidCourse.DisplayCourseInfo();

        Console.WriteLine("\n");
        OnlineCourse onlineCourse = new OnlineCourse("Intro to C#", 30, "Coursera", false);
        Console.WriteLine("Online Course Details:");
        onlineCourse.DisplayCourseInfo();

        Console.WriteLine("\n");
        Course basicCourse = new Course("Basic Python", 20);
        Console.WriteLine("Basic Course Details:");
        basicCourse.DisplayCourseInfo();
    }
}
