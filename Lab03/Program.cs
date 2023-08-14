internal class Program
{
    private static void Main(string[] args)
    {
        List<int> lst = new List<int>();
        lst.Add(1);
        lst.Add(24); 
        lst.Add(3);

        Console.WriteLine("Danh sách demo");
        foreach(var item in lst)
        {
            Console.WriteLine(item);
        }

        lst.Sort();
        foreach (var item in lst)
        {
            Console.WriteLine(item);
        }
        lst.Sort((x, y) => { return y - x; });
        foreach (var item in lst)
        {
            Console.WriteLine(item);
        }



    }
}