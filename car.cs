using System;

class Car
{
    protected string model;
    protected int enginePower;
    protected int numberOfSeats;
    protected int yearOfManufacture;

    public Car(string model, int enginePower, int numberOfSeats, int yearOfManufacture)
    {
        this.model = model;
        this.enginePower = enginePower;
        this.numberOfSeats = numberOfSeats;
        this.yearOfManufacture = yearOfManufacture;
    }

    public virtual double CalculateQuality()
    {
        double q = 0.1 * numberOfSeats;
        return q;
    }

    public void DisplayInformation()
    {
        Console.WriteLine("Car Information:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Engine Power: " + enginePower + " kW");
        Console.WriteLine("Number of Seats: " + numberOfSeats);
        Console.WriteLine("Year of Manufacture: " + yearOfManufacture);
    }
}

class SpecialCar : Car
{
    private int additionalFieldP;

    public SpecialCar(string model, int enginePower, int numberOfSeats, int yearOfManufacture, int additionalFieldP)
        : base(model, enginePower, numberOfSeats, yearOfManufacture)
    {
        this.additionalFieldP = additionalFieldP;
    }

    public override double CalculateQuality()
    {
        int currentYear = DateTime.Now.Year;
        double q = base.CalculateQuality() - 1.5 * (currentYear - yearOfManufacture);
        return q;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Toyota Camry", 150, 5, 2018);
        car1.DisplayInformation();
        Console.WriteLine("Quality: " + car1.CalculateQuality());

        Console.WriteLine();

        SpecialCar specialCar1 = new SpecialCar("BMW X5", 250, 5, 2020, 2005);
        specialCar1.DisplayInformation();
        Console.WriteLine("Quality: " + specialCar1.CalculateQuality());
    }
}
