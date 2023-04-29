using System;

class Program
{
    static void Main(string[] args)
    {
        Winchester winchester = new Winchester(500);
        RAM ram = new RAM(8);
        Processor processor = new Processor("Intel i5");
        VideoCard videoCard = new VideoCard("Nvidia GeForce GTX 1650");

        Computer computer = new Computer(winchester, ram, processor, videoCard);

        computer.Enable();
        computer.CheckForViruses();
        computer.DisplayHardDriveSize();
        computer.Disable();
    }
}

class Computer
{
    private Winchester winchester;
    private RAM ram;
    private Processor processor;
    private VideoCard videoCard;
    private bool enabled;

    public Computer(Winchester winchester, RAM ram, Processor processor, VideoCard videoCard)
    {
        this.winchester = winchester;
        this.ram = ram;
        this.processor = processor;
        this.videoCard = videoCard;
        this.enabled = false;
    }

    public void Enable()
    {
        enabled = true;
        Console.WriteLine("Computer enabled.");
    }

    public void Disable()
    {
        enabled = false;
        Console.WriteLine("Computer disabled.");
    }

    public void CheckForViruses()
    {
        if (enabled)
        {
            Console.WriteLine("Scanning for viruses...");
            // Virus scanning logic here
            Console.WriteLine("No viruses found.");
        }
        else
        {
            Console.WriteLine("Computer is disabled. Enable it first to check for viruses.");
        }
    }

    public void DisplayHardDriveSize()
    {
        Console.WriteLine("Hard drive size: " + winchester.Size + " GB");
    }
}

class Winchester
{
    public int Size { get; }

    public Winchester(int size)
    {
        Size = size;
    }
}

class RAM
{
    public int Capacity { get; }

    public RAM(int capacity)
    {
        Capacity = capacity;
    }
}

class Processor
{
    public string Model { get; }

    public Processor(string model)
    {
        Model = model;
    }
}

class VideoCard
{
    public string Manufacturer { get; }

    public VideoCard(string manufacturer)
    {
        Manufacturer = manufacturer;
    }
}
