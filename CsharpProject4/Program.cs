// Array and foreach loop exercise

int exerciseNum = 3;

if (exerciseNum == 1)
{
    /***************************
    * Exercise 1 - Array
    ***************************/
    // Alternative 1
    // Declaration
    // string[] fraudulentOrderIDs = new string[3];

    // // Assignment
    // fraudulentOrderIDs[0] = "A123";
    // fraudulentOrderIDs[1] = "B421";
    // fraudulentOrderIDs[2] = "C745";


    // Alternative 2
    // Initialise
    string[] fraudulentOrderIDs = ["A123", "B421", "C745"];
    //string[] problematicOrderIDs = {"A123", "B421", "C745"}; // Old syntax

    // Retrieve value
    Console.WriteLine($"First: \t{fraudulentOrderIDs[0]}");
    Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
    Console.WriteLine($"Third: \t{fraudulentOrderIDs[2]}");

    // Reassign
    fraudulentOrderIDs[0] = "F243";
    Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

    // Array length property
    Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process");
}
else if (exerciseNum == 2)
{
    /***************************
    * Exercise 2 - Foreach Loop
    ***************************/
    // Example 1
    Console.WriteLine("*****************************");
    Console.WriteLine("\tExample 1:");
    Console.WriteLine("*****************************");

    string[] names = ["Rowan", "Peter", "Gwen"];

    foreach (string name in names)
    {
        Console.WriteLine(name);
    }

    // Example 2
    Console.WriteLine("*****************************");
    Console.WriteLine("\tExample 2:");
    Console.WriteLine("*****************************");

    int[] inventory = [200, 450, 700, 175, 250];
    int sum = 0;
    int bin = 0;

    foreach (int items in inventory)
    {
        sum += items;
        bin++;
        Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
    }

    Console.WriteLine($"We have {sum} items in inventory.");

}
else
{
    // Challenge
    Console.WriteLine("*****************************");
    Console.WriteLine("\tChallenge:");
    Console.WriteLine("*****************************");

    string[] fraudulentOrderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
    int orderIdFound = 0;

    foreach (string checkIDs in fraudulentOrderIDs)
    {
        if (checkIDs.StartsWith("B"))
        { // check the beginnning of string matches with argument
            Console.WriteLine($"Possible fraudulent IDs: {checkIDs}");
            orderIdFound++;
        }
    }

    Console.WriteLine($"A total of {orderIdFound} possible fraudulent IDs has been found!");

}


