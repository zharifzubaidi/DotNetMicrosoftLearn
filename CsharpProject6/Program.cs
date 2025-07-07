// Boolean expression
string userInput = "";
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

if (userInput != null)
{
    if (userInput == "1")
    {
        // Equality operator
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 1:");
        Console.WriteLine("*****************************");

        Console.WriteLine("a" == "a");
        Console.WriteLine("A" == "a");
        Console.WriteLine(1 == 2);

        string myValue = "a";
        Console.WriteLine(myValue == "a");

        // Implement data cleanup before checking. convert all to lowercase and trim blank space
        string value1 = " a";
        string value2 = "A ";
        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
    }
    else if (userInput == "2")
    {
        // Inequality operator
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 2:");
        Console.WriteLine("*****************************");

        Console.WriteLine("a" != "a");
        Console.WriteLine("a" != "A");
        Console.WriteLine(1 != 2);

        string myValue = "a";
        Console.WriteLine(myValue != "a");
    }
    else if (userInput == "3")
    {
        // Comparison
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");

        Console.WriteLine(1 > 2);
        Console.WriteLine(1 < 2);
        Console.WriteLine(1 >= 2);
        Console.WriteLine(1 <= 2);
    }
    else if (userInput == "4")
    {
        // Method returns a Boolean
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 4:");
        Console.WriteLine("*****************************");
        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(pangram.Contains("fox"));
        Console.WriteLine(pangram.Contains("cow"));
    }
    else if (userInput == "5")
    {
        // Logical negation - unary negation operator
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 5:");
        Console.WriteLine("*****************************");
        string pangram = "The quick brown fox jumps over the lazy dog.";
        // These two lines of code will create the same output
        Console.WriteLine(pangram.Contains("fox") == false);
        Console.WriteLine(!pangram.Contains("fox"));

        Console.WriteLine(!pangram.Contains("fox"));
        Console.WriteLine(!pangram.Contains("cow"));
    }
    else if (userInput == "6")
    {
        // Inequality operator versus logical negation
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 6:");
        Console.WriteLine("*****************************");

        int a = 7;
        int b = 6;
        Console.WriteLine(a != b); // output: True
        string s1 = "Hello";
        string s2 = "Hello";
        Console.WriteLine(s1 != s2); // output: False
    }
    else if (userInput == "7")
    {
        // Conditional operator
        // Syntax: <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 7:");
        Console.WriteLine("*****************************");

        int saleAmount = 1001;
        /*
        int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine($"Discount: {discount} euro");
        */
        Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
    }
    else if (userInput == "8")
    {
        // Exercise 1
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 1:");
        Console.WriteLine("*****************************");

        Random coin = new Random();
        int flip = coin.Next(0, 2);
        Console.WriteLine((flip == 0) ? "heads" : "tails");
    }
    else if (userInput == "9")
    {
        // Exercise 2
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 2:");
        Console.WriteLine("*****************************");

        string permission = "Admin";
        int level = 56;

        if (permission.Contains("Admin") && level > 55)
        {
            Console.WriteLine("Welcome, Super Admin user.");
        }
        else if (permission.Contains("Admin") && level <= 55)
        {
            Console.WriteLine("Welcome, Admin user.");
        }
        else if (permission.Contains("Manager") && level >= 20)
        {
            Console.WriteLine("Contact an Admin for access");
        }
        else if (permission.Contains("Manager") && level < 20)
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges");
        }
    }

    Console.WriteLine("Thank you! Please press enter to exit.");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Please try again");
}

