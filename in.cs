using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        
        // ISO 8601 format
        string isoFormat = now.ToString("o");
        Console.WriteLine(isoFormat);  // Example: '2024-06-22T13:49:08.1234567Z'
        
        // Custom format
        string customFormat = now.ToString("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine(customFormat);  // Example: '2024-06-22 13:49:08'
    }
}
