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
    private static void Main(string[] args)
    {
        Tiger tiger = new Tiger("Royal Tiger", 5, "A magnificent predator.");
        Dog dog = new Dog("Golden Retriever", 3, "A friendly and loyal companion.");
        Cat cat = new Cat("Siamese Cat", 2, "Known for their striking appearance.");

        tiger.ViewInfo();
        tiger.Speak();

        Console.WriteLine();

        dog.ViewInfo();
        dog.Speak();

        Console.WriteLine();

        cat.ViewInfo();
        cat.Speak();
    }
}