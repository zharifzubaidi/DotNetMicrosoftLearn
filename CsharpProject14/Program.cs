﻿
// C# array operation

string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

if (userInput != null)
{
    if (userInput == "1")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 1:");
        Console.WriteLine("*****************************");
        string[] pallets = ["B14", "A11", "B12", "A13"];

        Console.WriteLine("Sorted...");
        Array.Sort(pallets);    // sorted
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Array.Reverse(pallets); // reverse
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }
    else if (userInput == "2")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 2:");
        Console.WriteLine("*****************************");

        string[] pallets = ["B14", "A11", "B12", "A13"];
        Console.WriteLine("");

        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

    }
    else if (userInput == "3")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");

        string[] pallets = ["B14", "A11", "B12", "A13"];
        Console.WriteLine("");

        Console.WriteLine($"Before: {pallets[0]}");
        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"After: {pallets[0]}");

        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

    }
    else if (userInput == "4")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 4:");
        Console.WriteLine("*****************************");

        string[] pallets = ["B14", "A11", "B12", "A13"];
        Console.WriteLine("");

        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 3);
        Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

    }
    else if (userInput == "5")
    {
        // ToCharArray()
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 5:");
        Console.WriteLine("*****************************");
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);
        string result = new string(valueArray);
        Console.WriteLine(result);

    }
    else if (userInput == "6")
    {
        // Join()
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 6:");
        Console.WriteLine("*****************************");
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);
        // string result = new string(valueArray);
        string result = String.Join(",", valueArray);
        Console.WriteLine(result);

    }
    else if (userInput == "7")
    {
        // Split()
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 7:");
        Console.WriteLine("*****************************");

        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);
        // string result = new string(valueArray);
        string result = String.Join(",", valueArray);
        Console.WriteLine(result);

        string[] items = result.Split(',');
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }

    }
    else if (userInput == "8")
    {
        // Challenge
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 8:");
        Console.WriteLine("*****************************");

        string pangram = "The quick brown fox jumps over the lazy dog";

        string[] message = pangram.Split(' ');

        string[] newMessage = new string[message.Length];

        for (int i = 0; i < message.Length; i++)
        {
            char[] letters = message[i].ToCharArray();
            Array.Reverse(letters);
            newMessage[i] = new string(letters);
        }

        string result = String.Join(" ", newMessage);
        Console.WriteLine(result);

    }
    else if (userInput == "9")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 9:");
        Console.WriteLine("*****************************");

        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        string[] items = orderStream.Split(',');
        Array.Sort(items);

        foreach (var item in items)
        {
            if (item.Length == 4)
            {
                Console.WriteLine(item);
            }
            else
            {
                Console.WriteLine(item + "\t- Error");
            }
        }
    }
    Console.WriteLine("Thank you! Please press enter to exit.");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Please try again");
}

