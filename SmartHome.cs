using System;
public class Device
{
    // Properties for DeviceId and Status
    public string DeviceId { get; set; }
    public string Status { get; set; }
    public Device(string deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Device ID: {DeviceId}");
        Console.WriteLine($"Status: {Status}");
    }
}
public class Thermostat : Device
{
    public double TemperatureSetting { get; set; }
    public Thermostat(string deviceId, string status, double temperatureSetting)
        : base(deviceId, status)
    {
        TemperatureSetting = temperatureSetting;
    }
    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
    }
}
public class Program
{
    public static void Main()
    {
        Thermostat thermostat = new Thermostat("TH12345", "On", 22.5);
        thermostat.DisplayStatus();
    }
}
