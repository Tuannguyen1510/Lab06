using Lab06._3;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Car> cars = new List<Car>
        {
            new Car { Name = "Car1", Color = "Red" },
            new Car { Name = "Car2", Color = "Blue" },
            new Car { Name = "Car3", Color = "Red" },
            new Car { Name = "Car4", Color = "Red" },
            new Car { Name = "Car5", Color = "Blue" },
            new Car { Name = "Car6", Color = "Green" },
            new Car { Name = "Car7", Color = "Red" },
            new Car { Name = "Car8", Color = "Green" },
            new Car { Name = "Car9", Color = "Blue" },
            new Car { Name = "Car10", Color = "Red" },

        };

        // Xóa các Car có màu Red
        cars.RemoveAll(car => car.Color.Equals("Red", StringComparison.OrdinalIgnoreCase));

        // In danh sách các Car
        Console.WriteLine("Danh sách các Car sau khi xóa các Car màu Red:");
        foreach (var car in cars)
        {
            Console.WriteLine($"Name: {car.Name}, Color: {car.Color}");
        }
    }
}