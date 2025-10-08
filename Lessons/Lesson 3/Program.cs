// --------------------------------------
// Autor: Diogo Gonçalves
// Data: 06/10/2025
// GitHub: https://github.com/diogodelmar
// --------------------------------------

using System;
using Lesson_3.Ex;
using Microsoft.VisualBasic;

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Criar um objeto

            Vehicle vehicle = new Vehicle("Peugeot", "Grey", 2021); // Formato de dados definida (brand,color,year)
            vehicle.Drive(); // Chama os métodos
            vehicle.Honk();

            Car car = new Car("BMW","White",2024,5);

            car.Drive();
            car.Honk();

            Moto moto = new Moto("Yamaha", "Black", 2023, false); // True or false por causa do datatype bool

            moto.Drive();
            moto.Honk();
        }
    }
}
