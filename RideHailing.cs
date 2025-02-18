using System;
abstract class Vehicle
{
    public int VehicleId { get; private set; }
    public string DriverName { get; private set; }
    public double RatePerKm { get; private set; }

    public Vehicle(int vehicleId, string driverName, double ratePerKm)
    {
        VehicleId = vehicleId;
        DriverName = driverName;
        RatePerKm = ratePerKm;
    }

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine($"Vehicle ID: {VehicleId}, Driver: {DriverName}, Rate per Km: {RatePerKm:C}");
    }
}
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}
class Car : Vehicle, IGPS
{
    private string location;

    public Car(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string newLocation)
    {
        location = newLocation;
    }
}
class Bike : Vehicle, IGPS
{
    private string location;

    public Bike(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm * 0.9; // 10% discount for bike rides
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string newLocation)
    {
        location = newLocation;
    }
}
class Auto : Vehicle, IGPS
{
    private string location;

    public Auto(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm * 1.1; // 10% extra charge for auto rides
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string newLocation)
    {
        location = newLocation;
    }
}

// Program execution
class Program
{
    static void Main()
    {
        Vehicle car = new Car(101, "John Doe", 10);
        car.GetVehicleDetails();
        Console.WriteLine($"Fare for 15 km: {car.CalculateFare(15):C}");

        Console.WriteLine();

        Vehicle bike = new Bike(102, "Alice Smith", 8);
        bike.GetVehicleDetails();
        Console.WriteLine($"Fare for 15 km: {bike.CalculateFare(15):C}");

        Console.WriteLine();

        Vehicle auto = new Auto(103, "Bob Williams", 6);
        auto.GetVehicleDetails();
        Console.WriteLine($"Fare for 15 km: {auto.CalculateFare(15):C}");
    }
}
