
// Data types

string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

if (userInput != null)
{
    if (userInput == "1")
    {
        // Signed integral type
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 1:");
        Console.WriteLine("*****************************");

        Console.WriteLine("Signed integral types:");

        Console.WriteLine($"sbyte\t: {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"short\t: {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"int\t: {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"long\t: {long.MinValue} to {long.MaxValue}");

    }
    else if (userInput == "2")
    {
        // Unsigned integral type
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 2:");
        Console.WriteLine("*****************************");

        Console.WriteLine("");
        Console.WriteLine("Unsigned integral types:");

        Console.WriteLine($"byte\t: {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"ushort\t: {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"uint\t: {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"ulong\t: {ulong.MinValue} to {ulong.MaxValue}");

    }
    else if (userInput == "3")
    {
        // Floating-point types
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");

        Console.WriteLine("");
        Console.WriteLine("Floating point types:");
        Console.WriteLine($"float : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
        Console.WriteLine($"double: {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
        Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

    }
    else if (userInput == "4")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 4:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "5")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 5:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "6")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 6:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "7")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 7:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "8")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 8:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "9")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 2:");
        Console.WriteLine("*****************************");

    }

    Console.WriteLine("Thank you! Please press enter to exit.");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Please try again");
}

