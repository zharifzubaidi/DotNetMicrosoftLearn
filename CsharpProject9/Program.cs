
// For loop

string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

if (userInput != null)
{
    if (userInput == "1")
    {
        // Basic for loop
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 1:");
        Console.WriteLine("*****************************");

        // Counter increment
        for (int i = 0; i <= 10; i++)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();

        // Counter decrement
        for (int i = 10; i >= 0; i--)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();

        // Modified counter increment
        for (int i = 0; i < 10; i += 3)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();

        // Use counter as condition to break
        for (int i = 0; i < 10; i++)
        {
            Console.Write(i);
            Console.Write(" ");
            if (i == 7) break;
        }
        Console.WriteLine();

        // Loop through array for each element from the last element
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.Write(names[i]);
            Console.Write(" ");
        }
        Console.WriteLine();

        // Loop through array for each element from the first element
        // Length will give number of element with zero-indexed. Need to minus one
        string[] names2 = { "Alex", "Eddie", "David", "Michael" };
        for (int i = 0; i < names2.Length; i++)
        {
            Console.Write(names[i]);
            Console.Write(" ");
        }
        Console.WriteLine();

        // Combination of for loop to substitute and foreach to display
        string[] names3 = { "Alex", "Eddie", "David", "Michael" };
        for (int i = 0; i < names3.Length; i++)
            if (names3[i] == "David")
            {
                names3[i] = "Sammy";
            }
        foreach (var name in names3)
        {
            Console.WriteLine(name);
        }
    }
    else if (userInput == "2")
    {
        // FizzBuzz logic
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 2:");
        Console.WriteLine("*****************************");
        for (int counter = 1; counter <= 100; counter++)
        {
            if ((counter % 3) == 0 && (counter % 5) == 0)
            {
                Console.WriteLine($"Number: {counter} FizzBuzz");
            }
            else if ((counter % 3) == 0)
            {
                Console.WriteLine($"Number: {counter} Fizz");
            }
            else if ((counter % 5) == 0)
            {
                Console.WriteLine($"Number: {counter} Buzz");
            }
            else
            {
                Console.WriteLine($"Number: {counter}");
            }
        }
    }
    else if (userInput == "3")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");
        

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
        Console.WriteLine("\tExercise 1:");
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

