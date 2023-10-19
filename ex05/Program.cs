using System;
using System.Collections.Generic;
using System.Linq;

public interface IVehicle
{
    void Drive();
}

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a car");
    }
}

public class Truck : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a truck");
    }
}

public class Motorcycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a motorcycle");
    }
}

class Program
{
    static void Main()
    {
        List<IVehicle> vehicles = new List<IVehicle>
        {
            new Car(),
            new Truck(),
            new Motorcycle(),
            new Car(),
            new Truck(),
            new Motorcycle(),
        };

        var cars = vehicles.OfType<Car>();

        Console.WriteLine("List of cars:");
        foreach (var car in cars)
        {
            car.Drive();
        }
    }
}
