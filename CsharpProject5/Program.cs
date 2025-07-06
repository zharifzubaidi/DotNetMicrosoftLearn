// Readable code examples

using System.Globalization;

int exercise = 3;

if (exercise == 1)
{
    // Example 1 - Comments
    // A higher level comment is prefered over a line by line comment
    /*
        The following code creates a five random OrderIDs
        to test the fraud detection process. OrderIDs
        consist of a letter from A to E, and a four
        digit number. Ex: A1234.
    */
    Console.WriteLine("*****************************");
    Console.WriteLine("\tExample 1:");
    Console.WriteLine("*****************************");

    // Order ID generator
    Random random = new Random();
    string[] orderIDs = new string[5];
    int num = 0;

    // Loop through each blank orderID
    for (int i = 0; i < orderIDs.Length; i++)
    {
        // Get a random value that equates to ASCII letters A through E
        int prefixValue = random.Next(65, 70);
        // Convert the random value into a char to get the ASCII letters and then to a string for printing to console
        string prefix = Convert.ToChar(prefixValue).ToString();
        // Create a random number and then set the number format in 3 digits "000" or 4 digits "0000"
        string suffix = random.Next(1, 1000).ToString("0000");
        // Combine the prefix and suffix together, then assign to current OrderID
        orderIDs[i] = prefix + suffix;
    }

    // Print out each orderID
    foreach (var orderID in orderIDs)
    {
        num++;
        Console.Write($"Order ID {num} generated:\t");
        Console.WriteLine(orderID);
    }

}
else if (exercise == 2)
{
    // Example 2 - White space
    Random dice = new Random();

    int roll1 = dice.Next(1, 7);
    int roll2 = dice.Next(1, 7);
    int roll3 = dice.Next(1, 7);

    int total = roll1 + roll2 + roll3;
    Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

    if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
    {
        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples!  +6 bonus to total!");
            total += 6;
        }
        else
        {
            Console.WriteLine("You rolled doubles!  +2 bonus to total!");
            total += 2;
        }
    }
}
else
{
    // Challenge
    /*
    string str = "The quick brown fox jumps over the lazy dog.";
    // convert the message into a char array
    char[] charMessage = str.ToCharArray();
    // Reverse the chars
    Array.Reverse(charMessage);
    int x = 0;
    // count the o's
    foreach (char i in charMessage) { if (i == 'o') { x++; } }
    // convert it back to a string
    string new_message = new String(charMessage);
    // print it out
    Console.WriteLine(new_message);
    Console.WriteLine($"'o' appears {x} times.");
    */

    // Solution
    /*
        This program is to convert a string variable into a char 
        array. Then, reverse the message and count how many O 
        appear in the char variable.
    */

    int x = 0;
    string inputText = "The quick brown fox jumps over the lazy dog.";
    char[] charMessage = inputText.ToCharArray();

    Array.Reverse(charMessage);

    foreach (char i in charMessage)
    {
        if (i == 'o') { x++; }
    }

    string newMessage = new String(charMessage);

    Console.WriteLine(newMessage);
    Console.WriteLine($"'o' appears {x} times.");
}