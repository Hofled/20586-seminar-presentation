using System;
using System.Configuration;

namespace AdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = ConfigurationManager.AppSettings;

            var name = configuration.Get("name");
            var number = int.Parse(configuration.Get("number"));

            Console.WriteLine($"name = {name}, number = {number}");

            Console.ReadLine();
        }
    }
}
