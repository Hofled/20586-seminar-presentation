using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Main function started...");

        // Run long running operation on the main thread
        LongRunningOperation();

        // The program continues execution here, while the new thread runs concurrently
        Console.WriteLine("Well this took a long time...");

        Console.WriteLine("Program finished.");

        Console.ReadLine();
    }

    static void LongRunningOperation()
    {
        Console.WriteLine("Long running operation started...");
        Thread.Sleep(5000);
        Console.WriteLine("Long running operation completed.");
    }
}
