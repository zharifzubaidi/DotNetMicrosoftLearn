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
        // Use of IndexOf() and LastIndexOf() helper methods
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");

        string message2 = "hello there!";

        int first_h = message2.IndexOf('h');
        int last_h = message2.LastIndexOf('h');

        Console.WriteLine($"For the message: '{message2}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

        break;
    
    case "4":
        // To retrive the last occurence of a sub string
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 4:");
        Console.WriteLine("*****************************");

        string message3 = "(What if) I am (only interested) in the last (set of parentheses)?";

        int openingPosition2 = message3.LastIndexOf('(');

        openingPosition2 += 1;

        int closingPosition2 = message3.LastIndexOf(')');

        int length4 = closingPosition2 - openingPosition2;

        Console.WriteLine(message3.Substring(openingPosition2, length4));

        break;
    
    case "5":
        // Retrieve all instances of substrings inside parentheses
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 5:");
        Console.WriteLine("*****************************");

        string message4 = "(What if) I am (only interested) in the last (set of parentheses)?";

        while (true)
        {
            int openingPosition3 = message4.IndexOf('(');
            if (openingPosition3 == -1)
                break;

            openingPosition3 += 1;

            int closingPosition3 = message4.IndexOf(')');
            int length5 = closingPosition3 - openingPosition3;
            Console.WriteLine(message4.Substring(openingPosition3, length5));

            message4 = message4.Substring(closingPosition3 + 1);
        }

        break;
    
    case "6":
        // Work with different types of symbol sets with IndexOfAny() 1
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 6:");
        Console.WriteLine("*****************************");

        string message5 = "Hello, world!";
        char[] charsToFind = { 'a', 'e', 'i' };

        int index = message5.IndexOfAny(charsToFind);

        Console.WriteLine($"Found '{message5[index]}' in '{message5}' at index: {index}.");

        break;

    case "7":
        // IndexOfAny() 2
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 7:");
        Console.WriteLine("*****************************");

        string message6 = "Help (find) the {opening symbols}";
        Console.WriteLine($"Searching THIS message: {message6}");
        char[] openSymbols = { '[', '{', '(' };
        int startPosition = 5;
        int openingPosition4 = message6.IndexOfAny(openSymbols);
        Console.WriteLine($"Found WITHOUT using startPosition: {message6.Substring(openingPosition4)}");

        openingPosition4 = message6.IndexOfAny(openSymbols, startPosition);
        Console.WriteLine($"Found WITH using startPosition {startPosition}: {message6.Substring(openingPosition4)}");

        break;

    case "8":
        // Index of any
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 8:");
        Console.WriteLine("*****************************");

        string message7 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

        // The IndexOfAny() helper method requires a char array of characters. 
        // You want to look for:

        char[] openSymbols1 = { '[', '{', '(' };

        // You'll use a slightly different technique for iterating through 
        // the characters in the string. This time, use the closing 
        // position of the previous iteration as the starting index for the 
        //next open symbol. So, you need to initialize the closingPosition 
        // variable to zero:

        int closingPosition4 = 0;

        while (true)
        {
            int openingPosition5 = message7.IndexOfAny(openSymbols1, closingPosition4);

            if (openingPosition5 == -1)
                break;

            string currentSymbol = message7.Substring(openingPosition5, 1);

            // Now  find the matching closing symbol
            char matchingSymbol = ' ';

            switch (currentSymbol)
            {
                case "[":
                    matchingSymbol = ']';
                    break;
                case "{":
                    matchingSymbol = '}';
                    break;
                case "(":
                    matchingSymbol = ')';
                    break;
            }

            // To find the closingPosition, use an overload of the IndexOf method to specify 
            // that the search for the matchingSymbol should start at the openingPosition in the string. 

            openingPosition5 += 1;
            closingPosition4 = message7.IndexOf(matchingSymbol, openingPosition5);

            // Finally, use the techniques you've already learned to display the sub-string:

            int length6 = closingPosition4 - openingPosition5;
            Console.WriteLine(message7.Substring(openingPosition5, length6));
        }

        break;

    case "9":
        // Remove()
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 9");
        Console.WriteLine("*****************************");

        string data = "12345John Smith          5000    3    ";
        string updatedData = data.Remove(5, 20);
        Console.WriteLine(updatedData);

        break;

    case "10":
        // Replace()
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 10");
        Console.WriteLine("*****************************");

        string message8 = "This--is--ex-amp-le--da-ta";
        message8 = message8.Replace("--", " ");
        message8 = message8.Replace("-", "");
        Console.WriteLine(message8);

        break;

    case "11":
        // Challenge
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 11");
        Console.WriteLine("*****************************");

        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        const string openSpan1 = "<span>";
        const string closeSpan1 = "</span>";

        // + length of <span> so index at end of <span> tag
        int quantityStart = input.IndexOf(openSpan1) + openSpan1.Length;
        int quantityEnd = input.IndexOf(closeSpan1);
        int quantityLength = quantityEnd - quantityStart;
        quantity = input.Substring(quantityStart, quantityLength);
        quantity = $"Quantity: {quantity}";

        // Set output to input, replacing the trademark symbol with the registered trademark symbol
        const string tradeSymbol = "&trade;";
        const string regSymbol = "&reg;";
        output = input.Replace(tradeSymbol, regSymbol);

        // Remove the opening <div> tag
        const string openDiv = "<div>";
        int divStart = output.IndexOf(openDiv);
        output = output.Remove(divStart, openDiv.Length);

        // Remove the closing </div> tag and add "Output:" to the beginning
        const string closeDiv = "</div>";
        int divCloseStart = output.IndexOf(closeDiv);
        output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

        Console.WriteLine(quantity);
        Console.WriteLine(output);

        break;

    case "12":
        //
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 12");
        Console.WriteLine("*****************************");

        break;

    case "13":
        //
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 13");
        Console.WriteLine("*****************************");

        break;

    case "14":
        //
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 14");
        Console.WriteLine("*****************************");

        break;

    case "15":
        //
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 15");
        Console.WriteLine("*****************************");

        break;

    default:
        Console.WriteLine("Wrong input. Please try again");
        break;
        
}
   
Console.WriteLine("Thank you! Please press enter to exit.");
Console.ReadLine();