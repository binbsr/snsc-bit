class ABC
{
    // Members: methods, fields, properties etc.
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(2342424);
        Console.WriteLine(true);
        Console.WriteLine(23423.334);
        Console.WriteLine(DateTime.Now);
    }

    // Datatypes: byte, short, int, long | float, double, decimal e.g. 234.3523424232423345345234535
    // 11111111 - 255
    // 00000000 - 0
    public double CalculateAverageAge(byte age1, byte age2, byte age3)
    {
        double av = (age1 + age2 + age3) / 3;
        return av;
    }
}


// Inheritance - Types: Single, Multilevel, Multiple, Hybrid
// Polymorphism - Method Overloading, Method Overriding
