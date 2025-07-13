// Class method
using System;
using System.Runtime.CompilerServices;

string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

switch (userInput)
{
    case "1":
        {
            // Basic
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 1:");
            Console.WriteLine("*****************************");

            // Method signature
            // void SayHello();

            // Calling a method
            // Can be call before or after definition
            SayHello();

            // Method definition
            void SayHello()
            {
                Console.WriteLine("Hello World!");
            }

            break;
        }

    case "2":
        {
            // Method definition and call
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 2:");
            Console.WriteLine("*****************************");

            // It is common to see method defined at the end of a program

            int[] a = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Contents of array: ");
            PrintArray();

            void PrintArray()
            {
                foreach (int x in a)
                {
                    Console.WriteLine($"{x} ");
                }
                Console.WriteLine();
            }

            break;
        }

    case "3":
        {
            // Sample application
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 3:");
            Console.WriteLine("*****************************");

            Console.WriteLine("Generating random numbers");
            DisplayRandomNumbers();

            void DisplayRandomNumbers()
            {
                Random random = new Random();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{random.Next(1, 100)}");
                }

                Console.WriteLine();
            }

            break;
        }
    case "4":
        {
            // Example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 4:");
            Console.WriteLine("*****************************");

            int[] times = { 800, 1200, 1600, 2000 };
            int diff = 0;

            Console.WriteLine("Enter current GMT");
            int currentGMT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Current Medicine Schedule:");
            DisplayTimes();

            Console.WriteLine("Enter new GMT");
            int newGMT = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            {
                Console.WriteLine("Invalid GMT");
            }
            else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
            {
                diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                AdjustTimes();
            }
            else
            {
                diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
                AdjustTimes();

            }

            Console.WriteLine("New Medicine Schedule:");
            DisplayTimes();

            void AdjustTimes()
            {
                /* Adjust the times by adding the difference, keeping the value within 24 hours */
                for (int i = 0; i < times.Length; i++)
                {
                    times[i] = ((times[i] + diff)) % 2400;
                }
            }

            void DisplayTimes()
            {
                /* Format and display medicine times */
                foreach (int val in times)
                {
                    string time = val.ToString();
                    int len = time.Length;

                    if (len >= 3)
                    {
                        time = time.Insert(len - 2, ":");
                    }
                    else if (len == 2)
                    {
                        time = time.Insert(0, "0:");
                    }
                    else
                    {
                        time = time.Insert(0, "0:0");
                    }

                    Console.Write($"{time} ");
                }

                Console.WriteLine();
            }

            break;
        }
    case "5":
        {
            // Example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 5:");
            Console.WriteLine("*****************************");

            // Pseudocode
            /*
                if ipAddress consists of 4 numbers
                and
                if each ipAddress number has no leading zeroes
                and
                if each ipAddress number is in range 0 - 255

                then ipAddress is valid

                else ipAddress is invalid
            */
            // Variable declaration
            //string ipv4Input = "107.31.1.5";
            string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
            string[] address;
            bool validLength = false;
            bool validZeroes = false;
            bool validRange = false;

            // Business logic
            foreach (string ip in ipv4Input)
            {
                address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
                ValidateLength();
                ValidateZeroes();
                ValidateRange();

                if (validLength && validZeroes && validRange)
                {
                    Console.WriteLine($"{ip} is a valid IPv4 address");
                }
                else
                {
                    Console.WriteLine($"{ip} is an invalid IPv4 address");
                }
            }

            // Methods definition
            void ValidateLength()
            {
                //string[] address = ipv4Input.Split(".");
                validLength = address.Length == 4;
            }

            void ValidateZeroes()
            {
                //string[] address = ipv4Input.Split(".");
                foreach (string number in address)
                {
                    if (number.Length > 1 && number.StartsWith("0"))
                    {
                        validZeroes = false;
                        return;
                    }
                }
                validZeroes = true;
            }

            void ValidateRange()
            {
                //string[] address = ipv4Input.Split(".", StringSplitOptions.RemoveEmptyEntries); // remove empty entries

                foreach (string number in address)
                {
                    int value = int.Parse(number);
                    if (value < 0 || value > 255)
                    {
                        validRange = false;
                        return;
                    }
                }
                validRange = true;
            }

            break;
        }

    case "6":
        {
            // Challenge to create a reusable method
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 6:");
            Console.WriteLine("*****************************");

            Random random = new Random();
            int luck = random.Next(100);

            FortuneResult();

            void FortuneResult()
            {
                string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
                string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
                string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
                string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

                Console.WriteLine("A fortune teller whispers the following words:");
                string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"{text[i]} {fortune[i]} ");
                }
            }

            break;
        }
    case "7":
        {
            // Method with parameter 1
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 7:");
            Console.WriteLine("*****************************");

            CountTo(5);

            void CountTo(int max)
            {
                for (int i = 0; i < max; i++)
                {
                    Console.Write($"{i}, ");
                }
            }

            break;
        }
    case "8":
        {
            // Method with parameter 1
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 8:");
            Console.WriteLine("*****************************");

            int[] schedule = { 800, 1200, 1600, 2000 };

            // Method caller
            DisplayAdjustedTimes(schedule, 6, -6);

            // Method definitions
            void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
            {
                int diff = 0;

                // Calculation
                if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
                {
                    Console.WriteLine("Invalid GMT");
                }
                else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
                {
                    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                }
                else
                {
                    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
                }

                // Processing for display
                for (int i = 0; i < times.Length; i++)
                {
                    int newTime = ((times[i] + diff)) % 2400;
                    string newTimeMessage = newTime.ToString().PadLeft(4, '0');
                    string currentTimeMessage = times[i].ToString().PadLeft(4, '0');
                    Console.WriteLine($"{currentTimeMessage} -> {newTimeMessage}");
                }
            }

            break;
        }
    case "9":
        {
            // Method scope
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 9:");
            Console.WriteLine("*****************************");

            double pi = 3.14159; // Global variable
            PrintCircleInfo(12);
            PrintCircleInfo(24);

            void PrintCircleInfo(int radius)
            {
                Console.WriteLine($"Circle with radius {radius}");
                PrintCircleArea(radius);
                PrintCircleCircumference(radius);
            }
            void PrintCircleArea(int radius)
            {
                double area = pi * (radius * radius);
                Console.WriteLine($"Area = {area}");
            }

            void PrintCircleCircumference(int radius)
            {
                double circumference = 2 * pi * radius;
                Console.WriteLine($"Circumference = {circumference}");
            }

            break;
        }
    case "10":
        {
            // Pass by value
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 10:");
            Console.WriteLine("*****************************");

            int a = 3;
            int b = 4;
            int c = 0;

            Multiply(a, b, c);
            Console.WriteLine($"global statement: {a} x {b} = {c}");

            void Multiply(int a, int b, int c)
            {
                c = a * b;
                Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
            }

            break;
        }
    case "11":
        {
            // Pass by reference
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 11:");
            Console.WriteLine("*****************************");

            int[] array = { 1, 2, 3, 4, 5 };

            PrintArray(array);
            Clear(array);
            PrintArray(array);

            void PrintArray(int[] array)
            {
                foreach (int a in array)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
            }

            void Clear(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = 0;
                }
            }

            break;
        }
    case "12":
        {
            // Pass by reference string. Immutable type. A reference type but can't be altered once assigned
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 12:");
            Console.WriteLine("*****************************");

            string status = "Healthy";

            Console.WriteLine($"Start: {status}");
            SetHealth(false);
            Console.WriteLine($"End: {status}");

            void SetHealth(bool isHealthy)
            {
                status = (isHealthy ? "Healthy" : "Unhealthy");
                Console.WriteLine($"Middle: {status}");
            }

            break;
        }
    case "13":
        {
            // Method with optional arguments 1
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 13:");
            Console.WriteLine("*****************************");

            string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
            string[] rsvps = new string[10];
            int count = 0;

            // Method call
            AddRSVP("Rebecca", 1, "none", true);
            AddRSVP("Nadia", 2, "Nuts", true);
            AddRSVP("Linh", 2, "none", false);
            AddRSVP("Tony", 1, "Jackfruit", true);
            AddRSVP("Noor", 4, "none", false);
            AddRSVP("Jonte", 2, "Stone fruit", false);
            ShowRSVP();

            // Method definition
            void AddRSVP(string name, int partySize, string allergies, bool inviteOnly)
            {
                if (inviteOnly)
                {
                    bool found = false;
                    foreach (string guest in guestList)
                    {
                        if (guest.Equals(name))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine($"Sorry, {name} is not on the guest list");
                        return;
                    }
                }

                rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
                count++;
            }

            void ShowRSVP()
            {
                Console.WriteLine("\nTotal RSVPs:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(rsvps[i]);
                }
            }

            break;
        }
    case "14":
        {
            // Method with optional arguments 2 with declared optional parameters
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 14:");
            Console.WriteLine("*****************************");

            string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte", "Natasha", "Kila" };
            string[] rsvps = new string[10];
            int count = 0;

            // Method call
            AddRSVP("Rebecca", 1, "none", true);
            // Positional arguments
            AddRSVP("Nadia", 2, "Nuts", true);
            // Named arguments
            AddRSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
            // Named + positional arguments
            AddRSVP("Tony", inviteOnly: true, allergies: "Jackfruit", partySize: 1);

            AddRSVP("Noor", 4, "none", false);
            AddRSVP("Jonte", 2, "Stone fruit", false);

            AddRSVP("Natasha");
            AddRSVP("Kila", 2, "Nuts");
            ShowRSVP();

            // Method definition with default parameter value / declared optional parameters
            void AddRSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
            {
                if (inviteOnly)
                {
                    bool found = false;
                    foreach (string guest in guestList)
                    {
                        if (guest.Equals(name))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine($"Sorry, {name} is not on the guest list");
                        return;
                    }
                }

                rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
                count++;
            }

            void ShowRSVP()
            {
                Console.WriteLine("\nTotal RSVPs:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(rsvps[i]);
                }
            }


            break;
        }
    case "15":
        {
            // Challenge display email address
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 15:");
            Console.WriteLine("*****************************");

            // Data
            string[,] corporate =
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
            };

            string[,] external =
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            string externalDomain = "hayworth.com";


            // Business logic
            for (int i = 0; i < corporate.GetLength(0); i++)
            {
                // display internal email addresses
                DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
            }

            for (int i = 0; i < external.GetLength(0); i++)
            {
                // display external email addresses
                DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
            }

            // Method
            void DisplayEmail(string first, string last, string domain = "contoso.com")
            {
                string email = first.Substring(0, 2) + last;
                email = email.ToLower();
                Console.WriteLine($"{email}@{domain}");
            }

            break;
        }
    case "16":
        {
            // Method return
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 16:");
            Console.WriteLine("*****************************");

            double total = 0;
            double minimumSpend = 30.00;

            double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
            double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

            for (int i = 0; i < items.Length; i++)
            {
                total += GetDiscountedPrice(i);
            }

            // if (TotalMeetsMinimum())
            // {
            //     total -= 5.00;
            // }
            total -= TotalMeetsMinimum() ? 5.00 : 0.00;

            Console.WriteLine($"Total: RM{FormatDecimal(total)}");

            double GetDiscountedPrice(int itemIndex)
            {
                return items[itemIndex] * (1 - discounts[itemIndex]);
            }

            bool TotalMeetsMinimum()
            {
                return total >= minimumSpend;
            }

            string FormatDecimal(double input)
            {
                return input.ToString().Substring(0, 5);
            }

            break;
        }
    case "17":
        {
            // Return integer and double
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 17:");
            Console.WriteLine("*****************************");

            double usd = 23.73;
            int vnd = UsdToVnd(usd);

            Console.WriteLine($"${usd} USD = ${vnd} VND");
            Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

            int UsdToVnd(double usd)
            {
                int rate = 23500;
                return (int)(rate * usd);
            }

            double VndToUsd(int vnd)
            {
                double rate = 23500;
                return vnd / rate;
            }

            break;
        }
    case "18":
        {
            // Return reverse word strings
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 18:");
            Console.WriteLine("*****************************");

            string input = "snake";

            Console.WriteLine(input);
            Console.WriteLine(ReverseWord(input));

            string ReverseWord(string word)
            {
                string result = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];
                }
                return result;
            }

            break;
        }
    case "19":
        {
            // Return reverse word in a sentence strings
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 19:");
            Console.WriteLine("*****************************");

            string input = "there are snakes at the zoo";

            Console.WriteLine(input);
            Console.WriteLine(ReverseSentence(input));

            string ReverseSentence(string input)
            {
                string result = "";
                string[] words = input.Split(" ");

                foreach (string word in words)
                {
                    result += ReverseWord(word) + " ";
                }

                return result.Trim();
            }

            string ReverseWord(string word)
            {
                string result = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];
                }
                return result;
            }

            break;
        }
    case "20":
        {
            // Return booleans
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 20:");
            Console.WriteLine("*****************************");

            string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

            Console.WriteLine("Is it a palindrome?");
            foreach (string word in words) 
            {
                Console.WriteLine($"{word}: {IsPalindrome(word)}");
            }

            bool IsPalindrome(string word) // if word is still the same if start from front or rear
            {
                int start = 0;
                int end = word.Length - 1;

                while (start < end)
                {
                    if (word[start] != word[end])
                    {
                        return false;
                    }
                    start++;
                    end--;
                }
                return true;
            }

            break;
        }
    case "21":
        {
            // Return arrays
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 21:");
            Console.WriteLine("*****************************");

            int target = 60;
            int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
            int[] result = TwoCoins(coins, target);

            if (result.Length == 0)
            {
                Console.WriteLine("No two coins make change");
            }
            else
            {
                Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
            }

            int[] TwoCoins(int[] coins, int target)
            {
                for (int curr = 0; curr < coins.Length; curr++)
                {
                    for (int next = curr + 1; next < coins.Length; next++)
                    {
                        if (coins[curr] + coins[next] == target)
                        {
                            return new int[] { curr, next };
                        }
                    }
                }

                return new int[0];
            }

            break;
        }
    case "22":
        {
            // Return multidimensional array
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 22:");
            Console.WriteLine("*****************************");

            int target = 30;
            int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
            int[,] result = TwoCoins(coins, target);

            if (result.Length == 0) 
            {
                Console.WriteLine("No two coins make change");
            } 
            else 
            {
                Console.WriteLine("Change found at positions:");
                for (int i = 0; i < result.GetLength(0); i++) 
                {
                    if (result[i,0] == -1) 
                    {
                        break;
                    }
                    Console.WriteLine($"{result[i,0]},{result[i,1]}");
                }
            }

            int[,] TwoCoins(int[] coins, int target) 
            {
                int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
                int count = 0;

                for (int curr = 0; curr < coins.Length; curr++) 
                {
                    for (int next = curr + 1; next < coins.Length; next++) 
                    {    
                        if (coins[curr] + coins[next] == target) 
                        {
                            result[count, 0] = curr;
                            result[count, 1] = next;
                            count++;
                        }
                        if (count == result.GetLength(0)) 
                        {
                            return result;
                        }
                    }
                }
                return (count == 0) ? new int[0,0] : result;
            }
            break;
        }
    case "23":
        {
            // Challenge
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 23:");
            Console.WriteLine("*****************************");

            Random random = new Random();

            Console.WriteLine("Would you like to play? (Y/N)");
            if (ShouldPlay())
            {
                PlayGame();
            }

            bool ShouldPlay()
            {
                string response = Console.ReadLine();
                return response.ToLower().Equals("y");
            }

            void PlayGame()
            {
                var play = true;

                while (play)
                {
                    var target = GetTarget();
                    var roll = RollDice();

                    Console.WriteLine($"Roll a number greater than {target} to win!");
                    Console.WriteLine($"You rolled a {roll}");
                    Console.WriteLine(WinOrLose(roll, target));
                    Console.WriteLine("\nPlay again? (Y/N)");

                    play = ShouldPlay();
                }
            }

            int GetTarget()
            {
                return random.Next(1, 6);
            }

            int RollDice()
            {
                return random.Next(1, 7);
            }

            string WinOrLose(int roll, int target)
            {
                if (roll > target)
                {
                    return "You win!";
                }
                return "You lose!";
            }

            break;
        }
    case "24":
        {
            // 
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 24:");
            Console.WriteLine("*****************************");
            break;
        }
    case "25":
        {
            // 
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 25:");
            Console.WriteLine("*****************************");
            break;
        }
    case "26":
        {
            // 
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 26:");
            Console.WriteLine("*****************************");
            break;
        }
    case "27":
        {
            // 
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 27:");
            Console.WriteLine("*****************************");
            break;
        }
    case "28":
        {
            // 
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 28:");
            Console.WriteLine("*****************************");
            break;
        }
    case "29":
        {
            // 
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 29:");
            Console.WriteLine("*****************************");
            break;
        }
    case "30":
        {
            // 
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 30:");
            Console.WriteLine("*****************************");
            break;
        }
    default:
        {
            Console.WriteLine("Wrong input. Please try again");
            break;
        }
}