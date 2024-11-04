using System;
using System.Threading.Tasks;

class Program
{
    
    static async Task<string> GetDataFromDatabaseAsync()
    {
        Console.WriteLine("Підключення до бази даних...");

        
        await Task.Delay(2000); 

        Console.WriteLine("Отримання даних з бази...");
        return "Результат запиту до бази даних";
    }

    static async Task Main(string[] args)
    {
        Console.WriteLine("Запуск запиту до бази даних...");

       
        string result = await GetDataFromDatabaseAsync();

        
        Console.WriteLine($"Результат: {result}");
    }
}
