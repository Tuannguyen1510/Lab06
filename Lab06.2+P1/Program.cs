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

        public void ViewInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Description: {Description}");
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} is making a sound.");
        }
    }
    private static void Main(string[] args)
    {
        Animal animal1 = new Animal();
        animal1.ViewInfo();

        Animal animal2 = new Animal("Dog");
        animal2.ViewInfo();

        Animal animal3 = new Animal("Cat", 3);
        animal3.ViewInfo();

        Animal animal4 = new Animal("Elephant", 10, "A giant land mammal.");
        animal4.ViewInfo();

        Animal animal5 = new Animal { Name = "Tiger", Age = 7 };
        animal5.ViewInfo();
    }
}