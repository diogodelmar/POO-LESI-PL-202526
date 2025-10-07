using System;
using Lesson_3.Ex;
using Microsoft.VisualBasic;

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Criar um objeto

            Vehicle vehicle = new Vehicle("Peugeot", "Grey", 2021);
            vehicle.Drive();
            vehicle.Honk();

            Car car = new Car("BMW","White",2024,5);

            car.Drive();
            car.Honk();

            Moto moto = new Moto("Yamaha", "Black", 2023, false);

            moto.Drive();
            moto.Honk();
        }
    }
}
