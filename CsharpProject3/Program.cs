// See https://aka.ms/new-console-template for more information

// Decision logic: if-else exercise

/****************************
 * Exercise 1
 ***************************/
/*
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// Calculations
int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Double bonus point
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    total += 2;
    Console.WriteLine($"You rolled doubles! +2 bonus to total. New total: {total}");
}
// Triple bonus point
else if ((roll1 == roll2) && (roll2 == roll3))
{
    total += 6;
    Console.WriteLine($"You rolled triples! +6 bonus to total. New total: {total}");
}
else
{
    Console.WriteLine("Yay, another normal roll");
}

// Result
if (total > 14)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("You lose!");
}
*/

/****************************
 * Exercise 2
 ***************************/
/*
string message = "The quick brown fox jumps over the lazy dog";

bool result = message.Contains("dog");  // Check for substring existence in a string and return boolean result
Console.WriteLine(result);

if (message.Contains("fox"))
{
   Console.WriteLine("What does the fox say?");
}
*/

/****************************
 * Exercise 3
 ***************************/

Random random = new();
int daysUntilExpire = random.Next(16);  // 2 weeks. passed argument is a exclusion
int discountPercentage = 0;

daysUntilExpire = 5;    // test

Console.WriteLine($"{daysUntilExpire} days");

if (daysUntilExpire <= 14)
{
    if (daysUntilExpire >= 6 && daysUntilExpire <= 14)
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
    else if (daysUntilExpire > 1 && daysUntilExpire <= 5)
    {
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expires in {daysUntilExpire} days.\nRenew now and save {discountPercentage}%");
    }
    else if (daysUntilExpire == 1)
    {
        discountPercentage = 20;
        Console.WriteLine($"Your subscription expires within a day. \nRenew now and save {discountPercentage}%");
    }
    else
    {
        Console.WriteLine("Your subscription has expired.");
    }
}
else
{
    Console.WriteLine("Please continue watching!");
}
    