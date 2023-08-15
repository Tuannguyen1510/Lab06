using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable daysOfWeek = new Hashtable
        {
            { 1, "Sunday" },
            { 2, "Monday" },
            { 3, "Tuesday" },
            { 4, "Wednesday" },
            { 5, "Thursday" },
            { 6, "Friday" },
            { 7, "Saturday" }
        };

        // Tìm ngày Tuesday và in ra thông báo
        string tueDay = "Tuesday";
        if (daysOfWeek.ContainsValue(tueDay))
        {
            Console.WriteLine($"Tìm thấy ngày '{tueDay}' trong tuần.");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy ngày '{tueDay}' trong tuần.");
        }

        // In ra các ngày trong tuần bao gồm cả key và value
        Console.WriteLine("Danh sách các ngày trong tuần:");
        foreach (DictionaryEntry entry in daysOfWeek)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}