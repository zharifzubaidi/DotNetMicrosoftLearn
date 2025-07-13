// Class methods

string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

switch(userInput)
{
    case "1":
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 1:");
        Console.WriteLine("*****************************");
        break;
    }
    case "2":
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 2:");
        Console.WriteLine("*****************************");
        break;
    }
    case "3":
    {
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");
        break;
    }
    default:
    {
        Console.WriteLine("Wrong input. Please try again");
        break;
    }
}
   
Console.WriteLine("Thank you! Please press enter to exit.");
Console.ReadLine();