using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace AdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new SerializableObject{ Name = "Ofri", Age = 42, Secret = "Top Secret!" };

            Console.WriteLine($"Original Object: {obj}");

            var outputFile = "serialized_object.json";
            using(var fileStream = File.Create(outputFile))
            {
                var serializer = new DataContractJsonSerializer(typeof(SerializableObject));
                serializer.WriteObject(fileStream, obj);

                fileStream.Position = 0;
                var reader = new StreamReader(fileStream);
                var json = reader.ReadToEnd();
                Console.WriteLine(json);
            }

            Console.ReadLine();
        }
    }
}
