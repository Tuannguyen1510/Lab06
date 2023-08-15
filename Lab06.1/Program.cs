using Lab06._1;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Book A", Author = "Author A", Publisher = "Publisher X", Year = 2010, Price = 10.99 },
            new Book { Id = 2, Title = "Book B", Author = "Author B", Publisher = "Publisher Y", Year = 2015, Price = 8.99 },
            new Book { Id = 3, Title = "Book C", Author = "Author C", Publisher = "Publisher X", Year = 2014, Price = 13.99 },
            new Book { Id = 4, Title = "Book D", Author = "Author C", Publisher = "Publisher X", Year = 2014, Price = 15.99 },
            new Book { Id = 5, Title = "Book E", Author = "Author C", Publisher = "Publisher X", Year = 2014, Price = 5.99 },
            new Book { Id = 6, Title = "Book F", Author = "Author C", Publisher = "Publisher X", Year = 2014, Price = 2.99 },
            new Book { Id = 7, Title = "Book H", Author = "Author C", Publisher = "Publisher X", Year = 2014, Price = 1.99 },
            new Book { Id = 8, Title = "Book G", Author = "Author C", Publisher = "Publisher X", Year = 2014, Price = 3.99 },
            new Book { Id = 9, Title = "Book M", Author = "Author C", Publisher = "Publisher X", Year = 2014, Price = 6.99 },
            new Book { Id = 10, Title = "Book J", Author = "Author C", Publisher = "Nhi Dong", Year = 2014, Price = 12.99 },

            // Add more books here...
        };

        // In danh sách các quyển sách tăng dần theo giá
        Console.WriteLine("Danh sách các quyển sách tăng dần theo giá:");
        var sortedBooksByPrice = books.OrderBy(book => book.Price);
        foreach (var book in sortedBooksByPrice)
        {
            Console.WriteLine($"Title: {book.Title}, Price: {book.Price}");
        }

        // Tìm quyển sách có title trùng với giá trị nhập từ bàn phím
        Console.Write("Nhập title của quyển sách cần tìm: ");
        string searchTitle = Console.ReadLine();
        var bookWithTitle = books.FirstOrDefault(book => book.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase));
        if (bookWithTitle != null)
        {
            Console.WriteLine($"Quyển sách có title '{searchTitle}':");
            Console.WriteLine($"Title: {bookWithTitle.Title}, Author: {bookWithTitle.Author}, Price: {bookWithTitle.Price}");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy quyển sách có title '{searchTitle}'.");
        }

        // Đưa ra những quyển sách xuất bản năm 2014
        Console.WriteLine("Danh sách các quyển sách xuất bản năm 2014:");
        var booksPublishedIn2014 = books.Where(book => book.Year == 2014);
        foreach (var book in booksPublishedIn2014)
        {
            Console.WriteLine($"Title: {book.Title}, Publisher: {book.Publisher}");
        }

        // Xóa những quyển sách của nhà xuất bản “Nhi Dong”
        books.RemoveAll(book => book.Publisher.Equals("Nhi Dong", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Danh sách sau khi xóa các quyển sách của nhà xuất bản 'Nhi Dong':");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Publisher: {book.Publisher}");
        }
    }
}