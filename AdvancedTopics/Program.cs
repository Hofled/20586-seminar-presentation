using System;
using ExtensionMethodsNamespace;
using ExampleClasses;

namespace AdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Extension method - Describe() on the "Example" class

            Example example = new Example("Some name", 42);
            Console.WriteLine(example.Describe());

            #endregion

            Console.ReadLine();
        }
    }
}
