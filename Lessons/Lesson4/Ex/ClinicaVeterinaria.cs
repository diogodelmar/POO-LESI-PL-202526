
// --------------------------------------
// Autor: Diogo Gonçalves
// Data: 18/10/2025
// GitHub: https://github.com/diogodelmar
// --------------------------------------


using System.Buffers;

namespace Lesson4.Ex
{

    public class Client
    {
        public int Id { get; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        private readonly List<Animal> animals = new List<Animal>();

        public Client (int id, string fullName, string phoneNumber, string email)
        {
            if(string.IsNullOrEmpty(fullName))
            {
                throw new ArgumentException("Full name cannot be null or empty.", nameof(fullName));
            }
            if(string.IsNullOrEmpty(phoneNumber))
            {
                throw new ArgumentException("Phone number cannot be null or empty.", nameof(phoneNumber));
            }
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email cannot be null or empty.", nameof(email));
            }

            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            
        }
        public void AddAnimal(Animal animal)
        {
            if(animal == null)
            {
                throw new ArgumentNullException(nameof(animal), "Animal cannot be null.");
            }

            animals.Add(animal);
        }   
        List<Animal> GetAnimals()
        {
            return animals;
        }
        }

    public class Animal
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public Client Owner { get; set; }

        public Animal (int id, string name, string species, string breed , int age , Client owner)
        {
            Id = id;
            Name = name;
            Species = species;
            Breed = breed;
            Age = age;
            Owner = owner;
        }

        public void UpdateInfo(string name, string species, string breed, int age, Client owner)
        {
            Name = name;
            Species = species;
            Breed = breed;
            Age = age;
            Owner = owner;
        }
        public virtual void DisplaySummary()
        {
            Console.WriteLine($"Animal ID: {Id}, Name: {Name}, Species: {Species}, Breed: {Breed}, Age: {Age}, Owner: {Owner}");
        }
    }
    public class Veterinarian
    {
        public int Id { get; }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public string LicenseNumber { get; set; }

        public List<Appointment> appointments = new List<Appointment>();
        public Veterinarian (int id, string fullName, string specialty, string licenseNumber)
        {
            Id = id;
            FullName = fullName;
            Specialty = specialty;
            LicenseNumber = licenseNumber;
        }

        void listAppointments()
        {
            foreach(var appointment in appointments)
            {
                Console.WriteLine(appointment);
            }
        }

        void ConductAppointment(Appointment appointment)
        {
            if(appointment == null)
            {
                throw new ArgumentNullException(nameof(appointment), "Appointment cannot be null.");
            }
            Console.WriteLine($"Conducting appointment for {appointment.Animal.Name} with Dr. {FullName} on {appointment.Date} at {appointment.Time}.");
        }
    }
    public class Appointment
    {
        public int Id { get; }
        public Animal Animal { get; set; }
        public Veterinarian Veterinarian { get; set; }
        public DateTime Date { get; set; }
        public string Diagnosis { get; set; }
        public List<Treatment> Treatments = new List<Treatment>();
        public Appointment (int id, Animal animal, Veterinarian veterinarian, DateTime date, string diagnosis)
        {
            Id = id;
            Animal = animal;
            Veterinarian = veterinarian;
            Date = date;
            Diagnosis = diagnosis;
        }

        public void addTreatment(Treatment treatment)
        {
            if(treatment == null)
            {
                throw new ArgumentNullException(nameof(treatment), "Treatment cannot be null.");
            }
            Treatments.Add(treatment);
        }

        public void CancelAppointment()
        {
            Console.WriteLine($"Appointment for {Animal.Name} with Dr. {Veterinarian.FullName} on {Date} has been canceled.");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Appointment ID: {Id}, Animal: {Animal.Name}, Veterinarian: {Veterinarian.FullName}, Date: {Date}, Diagnosis: {Diagnosis}");
        }

    }

    public class Treatment
    {
        public int Id { get; }
        public string Description { get; set; }

        public List<Medication> Medications = new List<Medication>();
        public Treatment (int id, string description)
        {
            Id = id;
            Description = description;
        }
    }

}
