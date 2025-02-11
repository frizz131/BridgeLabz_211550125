using System;
class Vehicle {
    String model;
    int maxSpeed;
    public Vehicle(String model, int maxSpeed) {
        this.model = model;
        this.maxSpeed = maxSpeed;
    }
    public void displayInfo() {
        System.out.println("Model: " + model);
        System.out.println("Max Speed: " + maxSpeed + " km/h");
    }
}
interface Refuelable {
    void refuel(); 
}
class ElectricVehicle extends Vehicle {
    int batteryCapacity;
    public ElectricVehicle(String model, int maxSpeed, int batteryCapacity) {
        super(model, maxSpeed);
        this.batteryCapacity = batteryCapacity;
    }
    public void charge() {
        System.out.println(model + " is being charged. Battery capacity: " + batteryCapacity + " kWh.");
    }
    @Override
    public void displayInfo() {
        super.displayInfo();
        System.out.println("Battery Capacity: " + batteryCapacity + " kWh");
    }
}

class PetrolVehicle extends Vehicle implements Refuelable {
    int fuelTankCapacity;
    public PetrolVehicle(String model, int maxSpeed, int fuelTankCapacity) {
        super(model, maxSpeed);
        this.fuelTankCapacity = fuelTankCapacity;
    }
    @Override
    public void refuel() {
        System.out.println(model + " is being refueled. Fuel tank capacity: " + fuelTankCapacity + " liters.");
    }
    @Override
    public void displayInfo() {
        super.displayInfo();
        System.out.println("Fuel Tank Capacity: " + fuelTankCapacity + " liters");
    }
}
public class Main {
    public static void main(String[] args) {
        // Create an ElectricVehicle instance
        ElectricVehicle electricCar = new ElectricVehicle("Tesla Model 3", 250, 75);
        // Display information and charge the electric vehicle
        electricCar.displayInfo();
        electricCar.charge();
        System.out.println();
        PetrolVehicle petrolCar = new PetrolVehicle("Ford Mustang", 220, 50);
        // Display information and refuel the petrol vehicle
        petrolCar.displayInfo();
        petrolCar.refuel();
    }
}
