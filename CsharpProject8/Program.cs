
// Switch case

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

        int employeeLevel = 200;
        string employeeName = "John Smith";

        string title = "";

        switch (employeeLevel)
        {
            case 100:
                title = "Junior Associate";
                break;
            case 200:
                title = "Senior Associate";
                break;
            case 300:
                title = "Manager";
                break;
            case 400:
                title = "Senior Manager";
                break;
            default:
                title = "Associate";
                break;
        }

        Console.WriteLine($"{employeeName}, {title}");

    }
    else if (userInput == "2")
    {
        // Convert from if else to switch
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 2:");
        Console.WriteLine("*****************************");

        /*
            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            if (product[0] == "01")
            {
                type = "Sweat shirt";
            } else if (product[0] == "02")
            {
                type = "T-Shirt";
            } else if (product[0] == "03")
            {
                type = "Sweat pants";
            }
            else
            {
                type = "Other";
            }

            if (product[1] == "BL")
            {
                color = "Black";
            } else if (product[1] == "MN")
            {
                color = "Maroon";
            } else
            {
                color = "White";
            }

            if (product[2] == "S")
            {
                size = "Small";
            } else if (product[2] == "M")
            {
                size = "Medium";
            } else if (product[2] == "L")
            {
                size = "Large";
            } else
            {
                size = "One Size Fits All";
            }

            Console.WriteLine($"Product: {size} {color} {type}");
        */

        string sku = "03-W-M";
        string[] product = sku.Split('-');  // split by - delimiting characters
        string type = "";
        string color = "";
        string size = "";

        switch (product[0])
        {
            case "01":
                type = "Sweat shirt";
                break;

            case "02":
                 type = "T-Shirt";
                break;

            case "03":
                type = "Sweat pants";
                break;

            default:
                type = "Other";
                break;

        }

        switch (product[1])
        {
            case "BL":
                color = "Black";
                break;

            case "MN":
                color = "Maroon";
                break;

            case "W":
                color = "White";
                break;

            default:
                color = "Not in stock";
                break;

        }

        switch (product[2])
        {
            case "S":
                size = "Small";
                break;

            case "M":
                size = "Medium";
                break;

            case "L":
                size = "Large";
                break;

            default:
                size = "Free Size";
                break;
        }

        Console.WriteLine($"Product: {size} {color} {type}");

    }
    else if (userInput == "3")
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");

    }

    Console.WriteLine("Thank you! Please press enter to exit.");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Please try again");
}

