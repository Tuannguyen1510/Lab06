internal class Program
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

        public Animal()
        {
        }

        public Animal(string name)
        {
            Name = name;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Animal(string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} is making a sound.");
        }

        public void ViewInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Description: {Description}");
        }
    }

    class Tiger : Animal
    {
        public Tiger()
        {
        }

        public Tiger(string name) : base(name)
        {
        }

        public Tiger(string name, int age) : base(name, age)
        {
        }

        public Tiger(string name, int age, string description) : base(name, age, description)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the Tiger is roaring.");
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
        }

        public Dog(string name) : base(name)
        {
        }

        public Dog(string name, int age) : base(name, age)
        {
        }

        public Dog(string name, int age, string description) : base(name, age, description)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the Dog is barking.");
        }
    }

    class Cat : Animal
    {
        public Cat()
        {
        }

        public Cat(string name) : base(name)
        {
        }

        public Cat(string name, int age) : base(name, age)
        {
        }

        public Cat(string name, int age, string description) : base(name, age, description)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the Cat is meowing.");
        }
    }
    class Cage
    {
        public int CageNumber { get; set; }
        public List<Animal> AnimalList { get; } = new List<Animal>();

        public void AddAnimal(Animal a)
        {
            AnimalList.Add(a);
        }

        public void RemoveAnimal(string name)
        {
            Animal animalToRemove = AnimalList.Find(animal => animal.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (animalToRemove != null)
            {
                AnimalList.Remove(animalToRemove);
                Console.WriteLine($"{name} has been removed from cage {CageNumber}.");
            }
            else
            {
                Console.WriteLine($"{name} not found in cage {CageNumber}.");
            }
        }
    }
    class Zoo
    {
        public List<Cage> CageList { get; } = new List<Cage>();

        public void AddCage(Cage c)
        {
            CageList.Add(c);
        }

        public void RemoveCage(int c)
        {
            Cage cageToRemove = CageList.Find(cage => cage.CageNumber == c);
            if (cageToRemove != null)
            {
                CageList.Remove(cageToRemove);
                Console.WriteLine($"Cage {c} has been removed from the zoo.");
            }
            else
            {
                Console.WriteLine($"Cage {c} not found in the zoo.");
            }
        }
    }
    private static void Main(string[] args)
    {
        /*
        Cage cage1 = new Cage { CageNumber = 1 };
        Cage cage2 = new Cage { CageNumber = 2 };

        Tiger tiger = new Tiger("Royal Tiger", 5, "A magnificent predator.");
        Dog dog = new Dog("Golden Retriever", 3, "A friendly and loyal companion.");
        Cat cat = new Cat("Siamese Cat", 2, "Known for their striking appearance.");

        cage1.AddAnimal(tiger);
        cage1.AddAnimal(dog);

        cage2.AddAnimal(cat);

        cage1.RemoveAnimal("Golden Retriever");
        cage2.RemoveAnimal("Lion");
        */


        /*
        Zoo myZoo = new Zoo();

        Cage cage1 = new Cage { CageNumber = 1 };
        Cage cage2 = new Cage { CageNumber = 2 };

        Tiger tiger = new Tiger("Royal Tiger", 5, "A magnificent predator.");
        Dog dog = new Dog("Golden Retriever", 3, "A friendly and loyal companion.");
        Cat cat = new Cat("Siamese Cat", 2, "Known for their striking appearance.");

        cage1.AddAnimal(tiger);
        cage1.AddAnimal(dog);

        cage2.AddAnimal(cat);

        myZoo.AddCage(cage1);
        myZoo.AddCage(cage2);

        myZoo.RemoveCage(1);
        myZoo.RemoveCage(3);
        */

        Zoo myZoo = new Zoo();

        while (true)
        {
            Console.WriteLine("Zoo Management System Menu:");
            Console.WriteLine("1. Add Cage");
            Console.WriteLine("2. Remove Cage");
            Console.WriteLine("3. Add Animal");
            Console.WriteLine("4. Remove Animal");
            Console.WriteLine("5. Iterate Animals");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter cage number: ");
                    int cageNumber = int.Parse(Console.ReadLine());
                    Cage newCage = new Cage { CageNumber = cageNumber };
                    myZoo.AddCage(newCage);
                    Console.WriteLine($"Cage {cageNumber} has been added.");
                    break;

                case 2:
                    Console.Write("Enter cage number to remove: ");
                    int cageToRemove = int.Parse(Console.ReadLine());
                    myZoo.RemoveCage(cageToRemove);
                    break;

                case 3:
                    // Implement Add Animal functionality here
                    break;

                case 4:
                    // Implement Remove Animal functionality here
                    break;

                case 5:
                    IterateAnimals(myZoo);
                    break;

                case 6:
                    Console.WriteLine("Exiting Zoo Management System...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            Console.WriteLine();
        }

    }



    static void IterateAnimals(Zoo zoo)
    {
        Console.WriteLine("Iterating through animals in the zoo:");

        foreach (Cage cage in zoo.CageList)
        {
            Console.WriteLine($"Cage Number: {cage.CageNumber}");

            foreach (Animal animal in cage.AnimalList)
            {
                Console.WriteLine($"Animal Name: {animal.Name}");
                Console.WriteLine($"Animal Age: {animal.Age}");
                Console.WriteLine($"Animal Description: {animal.Description}");
                animal.Speak();
                Console.WriteLine();
            }
        }
    }
}