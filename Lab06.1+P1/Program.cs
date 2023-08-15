internal class Program
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

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
        Animal myAnimal = new Animal
        {
            Name = "Lion",
            Age = 5,
            Description = "A majestic carnivore."
        };

        myAnimal.ViewInfo();
        myAnimal.Speak();
    }
}