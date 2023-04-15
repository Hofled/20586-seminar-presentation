using System;

[AttributeUsage(AttributeTargets.Class)]
public class ObsoleteAttribute : Attribute
{
    public string Message { get; }

    public ObsoleteAttribute(string message)
    {
        Message = message;
    }
}

[Obsolete("This class is obsolete, don't use it anymore!")]
public class VeryOldClass
{
    public void VeryOldMethod()
    {
        Console.WriteLine("VeryOldMethod in VeryOldClass");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(VeryOldClass);

        bool isDeprecated = type.IsDefined(typeof(ObsoleteAttribute), false);

        if (isDeprecated)
        {
            ObsoleteAttribute deprecatedAttribute = (ObsoleteAttribute)type.GetCustomAttributes(typeof(ObsoleteAttribute), false)[0];
            Console.WriteLine($"VeryOldClass is obsolete: {deprecatedAttribute.Message}");
        }

        VeryOldClass obj = new VeryOldClass();
        obj.VeryOldMethod();

        Console.ReadLine();
    }
}

