namespace Lesson_2;

public class Car
{
    // Definir variáveis
    public string LicensePlate { get; }
    public string Color { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string NrOfDoors { get; set; }

    public void Start()
    {
        Console.WriteLine("Car Start");
    }

    public void Stop()
    {
        Console.WriteLine("Car Stop");
    }
    public void Display()
    {
        Console.WriteLine($"License Plate");
    }







}