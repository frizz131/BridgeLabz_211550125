using System;
public class Vehicle
{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }
    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
        Console.WriteLine($"Fuel Type: {FuelType}");
    }
}

public class Car : Vehicle
{
    public int SeatCapacity { get; set; }
    public Car(int maxSpeed, string fuelType, int seatCapacity)
        : base(maxSpeed, fuelType)
    {
        SeatCapacity = seatCapacity;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity: {SeatCapacity} passengers");
    }
}

public class Truck : Vehicle
{
    public int PayloadCapacity { get; set; }
    public Truck(int maxSpeed, string fuelType, int payloadCapacity)
        : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payloadCapacity;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Payload Capacity: {PayloadCapacity} kg");
    }
}

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType)
    {
        HasSidecar = hasSidecar;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Sidecar: {HasSidecar}");
    }
}

public class Program
{
    public static void Main()
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(200, "Petrol", 5),
            new Truck(120, "Diesel", 15000),
            new Motorcycle(180, "Petrol", true)
        };
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine("\nVehicle Details:");
            vehicle.DisplayInfo();
        }
    }
}
