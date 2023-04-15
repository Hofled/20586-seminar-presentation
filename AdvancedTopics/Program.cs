using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Starting thread...");

        Thread thread = new Thread(LongRunningOperation);
        thread.Start();

        Console.WriteLine("Main thread continues...");

        Thread.Sleep(500);

        // Receive input from user while we are waiting for the thread to finish
        Console.Write("\nPlease insert your name:");
        var name = Console.ReadLine();
        Console.WriteLine($"Thank you for waiting {name}, the computation will finish shortly...");

        // Wait for the thread to complete before exiting the program
        thread.Join();

        Console.WriteLine("Program finished.");

        Console.ReadLine();
    }

    static void LongRunningOperation()
    {
        Console.WriteLine("Long running operation started...");
        // Sleep for 10 seconds
        Thread.Sleep(10000);
        Console.WriteLine("Long running operation completed.");
    }
}
