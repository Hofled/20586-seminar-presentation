using ExampleClasses;

namespace ExtensionMethodsNamespace
{
    public static class ExtensionMethods
    {
        public static string Describe(this Example exampleInstance)
        {
            return $"Description of \"Example\" class instance: {exampleInstance}";
        }
    }
}
