namespace Lesson_3.Ex
{
    public class Vehicle
    {
        // Definir variáveis
        public string Brand { get; set; }
        public string Color { get;set; }
        public int Year { get;set; }

        public Vehicle(string brand, string color, int year) // Construtor
        {
            Brand = brand;
            Color = color;
            Year = year;
        }

        // Métodos
        public virtual void Drive() //Adicionar virtual para em baixo o override funcionar
        {
            Console.WriteLine($"Vehicle {Brand} is driving...");
        }
        public virtual void Honk()
        {
            Console.WriteLine("Vehicle Beep, Beep...");
        }

        
    }
    public class Car : Vehicle // Herda as variáveis da classe Vehicle
    {
        public int NrOfDoors { get; set; }

        public Car(string brand, string color, int year,int nrofdoors)
        :base(brand, color, year) // Chama o construtor da classe Vehicle
        {
            NrOfDoors = nrofdoors;
        }

        public override void Drive() // Override
        {
            Console.WriteLine($"Car {Brand} ({Color}, {Year}) with {NrOfDoors} doors is driving on the road...");
        }

        public override void Honk()
        {
            Console.WriteLine("Car Honk! Honk!");
        }
    }

    public class Moto : Vehicle // Herda da class vehicle
    {
        public bool HasSidecar { get; set; }

        public Moto(string brand, string color, int year, bool hassidecar)
            : base(brand, color, year) // Construtor de vehicle
        {
            HasSidecar = hassidecar;
        }

        public override void Drive()
        {
            Console.WriteLine($"Moto {Brand} ({Color}, {Year}) is speeding through the streets");
        }

        public override void Honk()
        {
            Console.WriteLine("Moto Beep! Beep!");
        }

    }

}
