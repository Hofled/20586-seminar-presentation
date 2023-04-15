using System;
using System.Threading.Tasks;

class Program
{
    // Note that the main function is now returning a 'Task' and is marked as 'async'
    static async Task Main()
    {
        Console.WriteLine("Starting async operation...");

        int result = await Task.Run(() => LongRunningOperation());

        Console.WriteLine($"Async operation completed with result: {result}");

        Console.WriteLine("Program finished.");

        Console.ReadLine();
    }

    static int LongRunningOperation()
    {
        Console.WriteLine("Long running operation started...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Long running operation completed.");
        return 42;
    }
}
