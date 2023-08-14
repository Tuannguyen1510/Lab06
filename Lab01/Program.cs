using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // Khởi tạo 
        ArrayList arr = new ArrayList();
        // properties 
        Console.WriteLine("Count: " + arr.Count);
        Console.WriteLine("Capacity: " + arr.Capacity);
        // Method 
        arr.Add("A");
        arr.Add(6);
        arr.Insert(1, true);

        Console.WriteLine("Count: " + arr.Count);
        Console.WriteLine("Capacity: " + arr.Capacity);

        string[] name = {"a", "b", "c"};
        arr.AddRange(name);

        Console.WriteLine("Count: " + arr.Count);
        Console.WriteLine("Capacity: " + arr.Capacity);


        // Duyệt Collection 
        // for, foreach, while, do..while, ....

        Console.WriteLine("Danh sách các phầ tử");
        for(int i=0; i< arr.Count; i++)
        {
            Console.WriteLine(i + " " + arr[i]);
        }
        //
        Console.WriteLine("Danh sách các phần tử");
        foreach(var item  in arr)
        {
            Console.WriteLine(item);
        }
        /*
        // method xóa (remove, removeAt , removeRange , Clear)
        arr.Remove("a");
        arr.RemoveAt(2);
        print(arr);

        arr.RemoveRange(1, 2);
        print(arr);
        // 
        arr.Clear();
        print(arr);
        */

        // Sx 
        //arr.Sort();
        //print(arr);

        arr = new ArrayList() { "A", "ab", "b7", "1", "z" };
        print(arr);


        arr.Sort(new CaseInsensitiveComparer());
        print(arr);
        arr.Sort();
        print(arr);
        // IndexOf 

        if(arr.IndexOf("A") > 0)
        {
            Console.WriteLine("Tìm thấy tại vị trí: "+ arr.IndexOf("A"));
        }
        else
        {
            Console.WriteLine("Không tìm thấy");
        }
        // Contain 
        if (arr.Contains("ab"))
        {
            Console.WriteLine("Có tìm thấy");
        }
        else
        {
            Console.WriteLine("Không tìm thấy");
        }
        // 
    

    }

    static void print(ArrayList arr)
    {
        Console.WriteLine("Danh sách các phần tử");
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}