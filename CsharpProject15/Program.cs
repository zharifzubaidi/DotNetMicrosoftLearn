
// Format alphanumeric data

string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

if (userInput != null)
{
    if (userInput == "1")
    {
        // Composite formating
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 1:");
        Console.WriteLine("*****************************");

        string first = "Hello";
        string second = "World";
        Console.WriteLine("{0} {1} !", first, second);
        Console.WriteLine("{1} {0} !", first, second);
        Console.WriteLine("{0} {0} {0} !", first, second);


    }
    else if (userInput == "2")
    {
        // String interpolation
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 2:");
        Console.WriteLine("*****************************");

        string first = "Hello";
        string second = "World";
        Console.WriteLine($"{first} {second} !");
        Console.WriteLine($"{second} {first} !");
        Console.WriteLine($"{first} {first} {first} !");
    }
    else if (userInput == "3")
    {
        // Formating currency
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");

        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");

    }
    else if (userInput == "4")
    {
        // Formating numbers
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 4:");
        Console.WriteLine("*****************************");

        decimal measurement = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N} units");   // 2 digits after decimal point
        Console.WriteLine($"Measurement: {measurement:N4} units");  // 4 digits after decimal point

    }
    else if (userInput == "5")
    {
        // Formating percentages
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 5:");
        Console.WriteLine("*****************************");

        decimal tax = .36785m;
        Console.WriteLine($"Tax rate: {tax:P2}");

    }
    else if (userInput == "6")
    {
        // Combine formatting approaches 1
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 6:");
        Console.WriteLine("*****************************");

        decimal price = 67.55m;
        decimal salePrice = 59.99m;
        // format the string
        string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
        // output the string
        Console.WriteLine(yourDiscount);
    }
    else if (userInput == "7")
    {
        // Combine formatting approaches 2
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 7:");
        Console.WriteLine("*****************************");

        decimal price = 67.55m;
        decimal salePrice = 59.99m;

        // format the string
        string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

        // insert/append new string into an existing string
        yourDiscount += $"A discount of {((price - salePrice) / price):P2}";

        // output the string
        Console.WriteLine(yourDiscount);

    }
    else if (userInput == "8")
    {
        // String interpolation
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 8:");
        Console.WriteLine("*****************************");

        int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subTotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;

        Console.WriteLine($"Invoice Number: {invoiceNumber}");
        Console.WriteLine($"    Shares:{productShares:N3} Product");
        Console.WriteLine($"        Sub Total: {subTotal:C}");
        Console.WriteLine($"            Tax: {taxPercentage:P2}");
        Console.WriteLine($"        Total Billed: {total:C}");

    }
    else if (userInput == "9")
    {
        // Format strings by adding whitespace before or after
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 9:");
        Console.WriteLine("*****************************");

        // add blank space to the left of a string
        string input = "Pad this";
        Console.WriteLine(input.PadLeft(12));   // 12 characters
        // add blank space to the right of a string
        Console.WriteLine(input.PadRight(12));

    }
    else if (userInput == "10")
    {
        // Overloaded method for padleft and right
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 10:");
        Console.WriteLine("*****************************");

        string input = "Pad this";
        Console.WriteLine(input.PadLeft(12, 'x'));
        Console.WriteLine(input.PadRight(12, '\\'));

    }
    else if (userInput == "11")
    {
        // Working with padded strings
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 11:");
        Console.WriteLine("*****************************");

        // Data
        string paymentId = "769C";
        string payeeName = "Mr.Stephen Ortega";
        string paymentAmount = "$5,000.00";

        // Data formatting
        var formattedLine = paymentId.PadRight(6);
        formattedLine += payeeName.PadRight(24);
        formattedLine += paymentAmount.PadLeft(10);

        // Display
        Console.WriteLine("1234567890123456789012345678901234567890123456789");
        Console.WriteLine(formattedLine);

    }
    else if (userInput == "12")
    {
        // Challenge
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 12:");
        Console.WriteLine("*****************************");

        string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        // Formatting
        Console.WriteLine($"Dear {customerName},\n");
        Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
        Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
        Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Give your current volume, your potential profit would be {newProfit:C2}.");

        Console.WriteLine("Here is a quick comparison\n");

        // Formatting
        string currentReturnMessage = $"{currentReturn:P2}";
        string currentProfitMessage = $"{currentProfit:C2}";
        string newReturnMessage = $"{newReturn:P2}";
        string newProfitMessage = $"{newProfit:C2}";

        // First row
        string comparisonMessage = currentProduct.PadRight(18);
        comparisonMessage += currentReturnMessage.PadLeft(10);
        comparisonMessage += currentProfitMessage.PadLeft(20);

        Console.WriteLine(comparisonMessage);

        // Second row
        comparisonMessage = newProduct.PadRight(18);
        comparisonMessage += newReturnMessage.PadLeft(10);
        comparisonMessage += newProfitMessage.PadLeft(20);

        Console.WriteLine(comparisonMessage);

        // Simplified alternative
        /*
        Console.WriteLine("Here's a quick comparison:\n");

        string comparisonMessage = "";

        comparisonMessage = currentProduct.PadRight(20);
        comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
        comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

        comparisonMessage += "\n";
        comparisonMessage += newProduct.PadRight(20);
        comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
        comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

        Console.WriteLine(comparisonMessage);
        */

    }
    else if (userInput == "13")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 13:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "14")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 14:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "15")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 15:");
        Console.WriteLine("*****************************");

    }
    else if (userInput == "16")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 16:");
        Console.WriteLine("*****************************");

    }
    Console.WriteLine("Thank you! Please press enter to exit.");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Please try again");
}

