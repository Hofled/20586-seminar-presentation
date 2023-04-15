using System;

namespace AdvancedTopics
{
    [Serializable]
    public class SerializableObject
    {
        public string Name;

        public int Age;

        [NonSerialized]
        public string Secret;


        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Secret: {Secret}";
        }
    }
}
