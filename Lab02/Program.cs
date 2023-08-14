using Lab02;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // sử dụng collection arraylist lưu trữ đt sv 

        ArrayList arrayList = new ArrayList()
       {
           new student()
           {
               Id=1,
               Name="a",
               Age=4
           },
             new student()
           {
               Id=2,
               Name="a",
               Age=5
           },
       };
        display(arrayList);
        // 
        student st = new student()
        {
            Id = 4,
            Name = "b",
            Age = 3
        };
        arrayList.Add(st);
        display(arrayList);

        // tìm kiếm 
        bool flag = false;
        foreach(student item in arrayList)
        {
            if(item.Age == 4)
            {
                flag = true;
                Console.WriteLine("{0},{1},{2}", item.Id, item.Name, item.Age);
            }
        }
        if(flag == false)
        {
            Console.WriteLine("Không tìm thấy");
        }
        // sx 
        Console.WriteLine("Sx");
        arrayList.Sort(new SortAge());
        display(arrayList);

        arrayList.Sort(new SortAgeDESC());
        display(arrayList);

    }
    static void display(ArrayList arr)
    {
        Console.WriteLine("Danh sach sv");
        foreach(student item in arr)
        {
            Console.WriteLine("{0},{1},{2}", item.Id, item.Name,item.Age);
        }
    }
    class SortAge : IComparer {
        public int Compare(Object? x, Object? y)
        {
            return (x as student).Age - (y as student).Age;
        }
    }

    class SortAgeDESC : IComparer
    {
        public int Compare(Object? x, Object? y)
        {
            return  (y as student).Age - (x as student).Age ;
        }
    }


}