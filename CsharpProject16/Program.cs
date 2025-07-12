// Built in data type methods in C#

using System.Data;

string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

switch (userInput)
{
    case "1":
        // IndexOf() and Substring() helper methods
        
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 1:");
        Console.WriteLine("*****************************");

        string message = "Find what is (inside the parentheses)";

        // Find parenthesis pairs index embedded in a string
        int openingPosition = message.IndexOf('('); // 13
        int closingPosition = message.IndexOf(')'); // 36

        //Console.WriteLine(openingPosition);
        //Console.WriteLine(closingPosition);

        // Use the parenthesis index as boundaries to retrieve value
        int length = closingPosition - openingPosition;
        int length2 = (closingPosition - openingPosition) + 1;
        int newOpeningPosition = openingPosition + 1;
        int length3 = closingPosition - newOpeningPosition;

        Console.WriteLine(message.Substring(openingPosition, length));  // output: (inside the parentheses
        Console.WriteLine(message.Substring(openingPosition, length2));  // output: (inside the parentheses)
        Console.WriteLine(message.Substring(newOpeningPosition, length3));  // output: inside the parentheses

        break;

    case "2":
        // Modify the starting position of the sub string
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 2:");
        Console.WriteLine("*****************************");

        
        string message1 = "What is the value <span>between the tags</span>?";
        /*
        Bad example
        int openingPosition1 = message1.IndexOf("<span>");  // using <span> directly is magic string. need to be avoided
        int closingPosition1 = message1.IndexOf("</span>");

        openingPosition1 += 6;  // magic number. need to be avoided
        */

        // Good example
        const string openSpan = "<span>";       // only change the delimiter opening/closing here and processing will take care of the rest
        const string closeSpan = "</span>";

        // Processing
        int openingPosition1 = message1.IndexOf(openSpan);
        int closingPosition1 = message1.IndexOf(closeSpan);
        openingPosition1 += openSpan.Length; // offset open position by span length

        int length1 = closingPosition1 - openingPosition1;

        Console.WriteLine(message1.Substring(openingPosition1, length1));

        break;

    case "3":
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");



        break;
    
    case "4":
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 4:");
        Console.WriteLine("*****************************");
        break;
    
    case "5":
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 5:");
        Console.WriteLine("*****************************");
        break;
    
    case "6":
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 6:");
        Console.WriteLine("*****************************");
        break;

    case "7":
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 7:");
        Console.WriteLine("*****************************");
        break;

    case "8":
        // 
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 8:");
        Console.WriteLine("*****************************");
        break;

    default:
        Console.WriteLine("Wrong input. Please try again");
        break;
        
}
   
Console.WriteLine("Thank you! Please press enter to exit.");
Console.ReadLine();