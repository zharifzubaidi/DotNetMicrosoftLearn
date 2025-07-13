/* 
    Debugging
    This code uses a names array and corresponding methods to display
    greeting messages
*/

/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

string? userInput = ""; // declare the string to expect a null value
Console.Write("Please select your example: ");
userInput = Console.ReadLine();

switch (userInput)
{
    case "1":
        {
            // 
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 1:");
            Console.WriteLine("*****************************");

            string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

            string messageText = "";

            foreach (string name in names)
            {
                if (name == "Sophia")
                    messageText = SophiaMessage();
                else if (name == "Andrew")
                    messageText = AndrewMessage();
                else if (name == "AllGreetings")
                {
                    messageText = SophiaMessage();
                    messageText = messageText + "\n\r" + AndrewMessage();
                }
                Console.WriteLine(messageText + "\n\r");
            }

            bool pauseCode = true;
            while (pauseCode == true) ;

            static string SophiaMessage()
            {
                return "Hello, my name is Sophia.";
            }

            static string AndrewMessage()
            {
                return "Hi, my name is Andrew. Good to meet you.";
            }
            break;
        }

    case "2":
        {
            // 
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 2:");
            Console.WriteLine("*****************************");

            int productCount = 2000;
            string[,] products = new string[productCount, 2];

            LoadProducts(products, productCount);

            for (int i = 0; i < productCount; i++)
            {
                string result;
                result = Process1(products, i);

                if (result != "obsolete")
                {
                    result = Process2(products, i);
                }
            }

            bool pauseCode = true;
            while (pauseCode == true) ;

            static void LoadProducts(string[,] products, int productCount)
            {
                Random rand = new Random();

                for (int i = 0; i < productCount; i++)
                {
                    int num1 = rand.Next(1, 10000) + 10000;
                    int num2 = rand.Next(1, 101);

                    string prodID = num1.ToString();

                    if (num2 < 91)
                    {
                        products[i, 1] = "existing";
                    }
                    else if (num2 == 91)
                    {
                        products[i, 1] = "new";
                        prodID = prodID + "-n";
                    }
                    else
                    {
                        products[i, 1] = "obsolete";
                        prodID = prodID + "-0";
                    }

                    products[i, 0] = prodID;
                }
            }
            static string Process1(string[,] products, int item)
            {
                Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

                return products[item, 1];
            }

            static string Process2(string[,] products, int item)
            {
                Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
                if (products[item, 1] == "new")
                    Process3(products, item);

                return "continue";
            }

            static void Process3(string[,] products, int item)
            {
                Console.WriteLine($"Process3 message - processing product information for 'new' product");
            }
            break;
        }
    case "3":
        {
            // Example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 3:");
            Console.WriteLine("*****************************");
            string? readResult;
            int startIndex = 0;
            bool goodEntry = false;

            int[] numbers = { 1, 2, 3, 4, 5 };

            // Display the array to the console.
            Console.Clear();
            Console.Write("\n\rThe 'numbers' array contains: { ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            // To calculate a sum of array elements, 
            //  prompt the user for the starting element number.
            Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
            while (goodEntry == false)
            {
                readResult = Console.ReadLine();
                goodEntry = int.TryParse(readResult, out startIndex);

                if (startIndex > 5)
                {
                    goodEntry = false;
                    Console.WriteLine("\n\rEnter an integer value between 1 and 5");
                }
            }

            // Display the sum and then pause.
            Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex - 1)}");

            Console.WriteLine("press Enter to exit");
            readResult = Console.ReadLine();

            // This method returns the sum of elements n through 5
            static int SumValues(int[] numbers, int n)
            {
                int sum = 0;
                for (int i = n; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum;
            }

            break;
        }

    case "4":
        {
            // Implement exception handling - Try catch
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 4:");
            Console.WriteLine("*****************************");

            double float1 = 3000.0;
            double float2 = 0.0;
            int number1 = 3000;
            int number2 = 0;

            try
            {
                Console.WriteLine(float1 / float2);
                Console.WriteLine(number1 / number2);
            }
            catch
            {
                Console.WriteLine("An exception has been caught!");
            }

            Console.WriteLine("Exit program");


            break;
        }
    case "5":
        {
            // Try catch - call stack unwinding example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 5:");
            Console.WriteLine("*****************************");
            try
            {
                Process1();
            }
            catch
            {
                Console.WriteLine("An exception has occurred");
            }

            Console.WriteLine("Exit program");

            static void Process1()
            {
                WriteMessage();
            }

            static void WriteMessage()
            {
                double float1 = 3000.0;
                double float2 = 0.0;
                int number1 = 3000;
                int number2 = 0;

                Console.WriteLine(float1 / float2);
                Console.WriteLine(number1 / number2);
            }
            break;
        }
    case "6":
        {
            // Example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 6:");
            Console.WriteLine("*****************************");

            try
            {
                Process1();
            }
            catch
            {
                Console.WriteLine("An exception has occurred");
            }

            Console.WriteLine("Exit program");

            static void Process1()
            {
                try
                {
                    WriteMessage();
                }
                catch
                {
                    Console.WriteLine("Exception caught in Process1");
                }
            }

            static void WriteMessage()
            {
                double float1 = 3000.0;
                double float2 = 0.0;
                int number1 = 3000;
                int number2 = 0;

                Console.WriteLine(float1 / float2);
                Console.WriteLine(number1 / number2);
            }
            break;
        }
    case "7":
        {
            // Challenge
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 7:");
            Console.WriteLine("*****************************");

            checked     //overflow protection. without this, overflow error can't be catch?
            {
                try
                {
                    int num1 = int.MaxValue;
                    int num2 = int.MaxValue;
                    int result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
                }
            }

            try
            {
                string? str = null;
                int length = str.Length;
                Console.WriteLine("String Length: " + length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error: The reference is null. " + ex.Message);
            }

            try
            {
                int[] numbers = new int[5];
                numbers[5] = 10;
                Console.WriteLine("Number at index 5: " + numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Index out of range. " + ex.Message);
            }

            try
            {
                int num3 = 10;
                int num4 = 0;
                int result2 = num3 / num4;
                Console.WriteLine("Result: " + result2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
            }

            Console.WriteLine("Exiting program.");

            break;
        }
    case "8":
        {
            // Example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 8:");
            Console.WriteLine("*****************************");
            break;
        }
    default:
        {
            Console.WriteLine("Wrong input. Please try again");
            break;
        }
}
