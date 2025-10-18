// --------------------------------------
// Autor: Diogo Gonçalves
// Data: 18/10/2025
// GitHub: https://github.com/diogodelmar
// --------------------------------------

using System;
using Lesson4.Ex;
using Microsoft.VisualBasic;

namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Criar um objeto

            Animal animal = new Animal(1, "Rex", "Dog", "German Shepherd", 5, "Diogo Gonçalves"); // Formato de dados definida (id, name, species, breed, age, owner)

            animal.DisplaySummary(); // Chama o método

            //animal.UpdateInfo();
        }
    }
}
