
// Do-while / while loop

using System.Runtime.CompilerServices;
using System.Threading.Channels;

string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

if (userInput != null)
{
    if (userInput == "1")
    {
        // Do-while loop
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 1:");
        Console.WriteLine("*****************************");
        Random random = new Random();
        int current = 0;

        do // Will execute at least once
        {
            current = random.Next(1, 11);
            Console.WriteLine(current);
        } while (current != 7); // exit condition

    }
    else if (userInput == "2")
    {
        // While loop
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 2:");
        Console.WriteLine("*****************************");

        Random random = new Random();
        int current = random.Next(1, 11);

        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Last number: {current}");

    }
    else if (userInput == "3")
    {
        // using continue statement to skip the rest of logic and go to boolean expression of the loop
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 3:");
        Console.WriteLine("*****************************");

        Random random = new Random();
        int current = random.Next(1, 11);

        do
        {
            current = random.Next(1, 11);
            if (current >= 8)
                continue;

            Console.WriteLine(current);
        } while (current != 7);

        Console.WriteLine("Number generation completed.");

    }
    else if (userInput == "4")
    {
        // Challenge 1
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 4:");
        Console.WriteLine("*****************************");

        Random random = new();
        int attackDamage = 0;
        int playerHealth = 10;
        int npcHealth = 10;
        bool playerTurn = true;

        do
        {
            attackDamage = random.Next(1, 11);
            if (playerTurn == true)
            {
                npcHealth -= attackDamage;
                playerTurn = false;
                Console.WriteLine($"NPC was damaged by player and lost {attackDamage} health and has {npcHealth} health.");
                if (npcHealth < 0)
                    npcHealth = 0;
            }
            else
            {
                playerHealth -= attackDamage;
                playerTurn = true;
                Console.WriteLine($"Player was damaged by NPC and lost {attackDamage} health and has {playerHealth} health.");
                if (playerHealth < 0)
                    playerHealth = 0;
            }

        } while (playerHealth > 0 || npcHealth > 0);

        if (playerHealth <= 0)
        {
            Console.WriteLine("Player has perished... Try again");
        }
        else if (npcHealth <= 0)
        {
            Console.WriteLine("Player has slain the enemy!");
        }
    }
    else if (userInput == "5")
    {
        // Challenge 2
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 5:");
        Console.WriteLine("*****************************");

        string? readResult;
        bool validEntry = false;

        // Check for null input 1
        Console.WriteLine("Enter a string:");
        do
        {
            readResult = Console.ReadLine();
        } while (readResult == null);

        // Check for null input 2
        Console.WriteLine("Enter a string containing at least three characters:");
        do
        {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                if (readResult.Length >= 3)
                {
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine("Your input is invalid, please try again.");
                }
            }
        } while (validEntry == false);

    }
    else if (userInput == "6")
    {
        // Convert user input into numeric
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 6:");
        Console.WriteLine("*****************************");
        int numericValue = 0;
        bool validNumber = false;
        string? readResult;

        Console.WriteLine("Enter a number between 5 and 10:");
        do
        {
            readResult = Console.ReadLine();
            validNumber = int.TryParse(readResult, out numericValue);   // out means load the value into the variable

            if (readResult != null)
            {
                if (validNumber && numericValue >= 5 && numericValue <= 10)
                {
                    Console.WriteLine($"Your number is: {numericValue}");
                }
                else if (validNumber && (numericValue < 5 || numericValue > 10))
                {
                    Console.WriteLine("Please try again with number between 5 and 10.");
                    Console.WriteLine("Enter a number between 5 and 10:");
                }
                else
                {
                    Console.WriteLine("Your input is invalid, please try again with number between 5 and 10.");
                    Console.WriteLine("Enter a number between 5 and 10:");
                }
            }
        } while (!(validNumber && numericValue >= 5 && numericValue <= 10));

    }
    else if (userInput == "7")
    {
        // Validates string input
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExample 7:");
        Console.WriteLine("*****************************");

        string? readResult1;
        string? roleLevel;

        do
        {
            Console.WriteLine("Please enter your role name (Administrator, Manager, User)");
            readResult1 = Console.ReadLine();
            roleLevel = readResult1.Trim().ToLower();
            switch (roleLevel)
            {
                case "administrator":
                case "manager":
                case "user":
                    Console.WriteLine($"Your input value ({roleLevel}) has been accepted.");
                    break;

                default:
                    Console.WriteLine("The role name that you entered, \"Admin\" is not valid. Enter your role name (Administrator, Manager, or User).");
                    break;
            }
        } while (!(roleLevel == "administrator" || roleLevel == "manager" || roleLevel == "user")); // loop in false condition. exit upon true condition

        Console.WriteLine("Complete.");
    }
    else if (userInput == "8")
    {
        // Processing string
        Console.WriteLine("*****************************");
        Console.WriteLine("\tExercise 8:");
        Console.WriteLine("*****************************");

        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of. the menu choices" };
        int stringsCount = myStrings.Length;

        string myString = "";
        int periodLocation = 0;

        for (int counter = 0; counter < stringsCount; counter++)
        {
            myString = myStrings[counter];
            periodLocation = myString.IndexOf(".");

            string mySentence;

            // Extract sentences from each string and display them one at a time
            while (periodLocation != -1)
            {
                // First sentence is the string value to the left of the period location
                mySentence = myString.Remove(periodLocation);
                

                // The remainder of myString is the string value tot the right of the location
                myString = myString.Substring(periodLocation + 1);
                

                // remove any leading white-space from mystring
                myString = myString.TrimStart();
                

                // update the dot / delimiter location and increment the counter
                periodLocation = myString.IndexOf(".");

                Console.WriteLine(mySentence);
            }
            mySentence = myString.Trim();
            Console.WriteLine(mySentence);
        }
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

