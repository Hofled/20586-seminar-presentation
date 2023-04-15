namespace ExampleClasses
{
    public class Example
    {
        private string name;
        private int number;

        public Example(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public override string ToString()
        {
            return $"Name: {name} | Number: {number}";
        }
    }
}
