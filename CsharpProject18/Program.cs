/* 
    Debugging
    This code uses a names array and corresponding methods to display
    greeting messages
*/

/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

using System.Diagnostics;
using System.Linq.Expressions;

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
            // Throw exception
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 8:");
            Console.WriteLine("*****************************");
            string[][] userEnteredValues = new string[][]
            {
                    new string[] { "1", "two", "3"},
                    new string[] { "0", "1", "2"}
            };

            foreach (string[] userEntries in userEnteredValues)
            {
                try
                {
                    BusinessProcess1(userEntries);
                }
                catch (Exception ex)
                {
                    if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            static void BusinessProcess1(string[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    try
                    {
                        valueEntered = int.Parse(userValue);

                        // completes required calculations based on userValue
                        // ...
                    }
                    catch (FormatException)
                    {
                        FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
                        throw invalidFormatException;
                    }
                }
            }

            break;
        }
    case "9":
        {
            // Exception
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 9:");
            Console.WriteLine("*****************************");

            try
            {
                OperatingProcedure1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exiting application.");
            }

            static void OperatingProcedure1()
            {
                string[][] userEnteredValues = new string[][]
                {
                    new string[] { "1", "two", "3"},
                    new string[] { "0", "1", "2"}
                };

                foreach(string[] userEntries in userEnteredValues)
                {
                    try
                    {
                        BusinessProcess1(userEntries);
                    }
                    catch (Exception ex)
                    {
                        if (ex.StackTrace.Contains("BusinessProcess1"))
                        {
                            if (ex is FormatException)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Corrective action taken in OperatingProcedure1");
                            }
                            else if (ex is DivideByZeroException)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                                // re-throw the original exception
                                throw;
                            }
                            else
                            {
                                // create a new exception object that wraps the original exception
                                throw new ApplicationException("An error occurred - ", ex);
                            }
                        }
                    }

                }
            }

            static void BusinessProcess1(string[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    try
                    {
                        valueEntered = int.Parse(userValue);

                        checked
                        {
                            int calculatedValue = 4 / valueEntered;
                        }
                    }
                    catch (FormatException)
                    {
                        FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
                        throw invalidFormatException;
                    }
                    catch (DivideByZeroException)
                    {
                        DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
                        throw unexpectedDivideByZeroException;

                    }
                }
            }
            break;
        }
    case "10":
        {
            // Example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 10:");
            Console.WriteLine("*****************************");

            // Prompt the user for the lower and upper bounds
            Console.Write("Enter the lower bound: ");
            int lowerBound = int.Parse(Console.ReadLine());

            Console.Write("Enter the upper bound: ");
            int upperBound = int.Parse(Console.ReadLine());

            decimal averageValue = 0;

            bool exit = false;

            do
            {
                try
                {
                    // Calculate the sum of the even numbers between the bounds
                    averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

                    // Display the value returned by AverageOfEvenNumbers in the console
                    Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

                    exit = true;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("An error has occured.");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"The upper bound must be greater than {lowerBound}");
                    Console.WriteLine($"Enter a new upper bound: ");
                    string? userResponse = Console.ReadLine();
                    if (userResponse.ToLower().Contains("exit"))
                    {
                        exit = true;
                    }
                    else
                    {
                        exit = false;
                        upperBound = int.Parse(userResponse);
                    }
                }
            } while (exit == false);


            // Wait for user input
            Console.ReadLine();

            static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
            {
                if (lowerBound >= upperBound)
                {
                    throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
                }
            
                int sum = 0;
                int count = 0;
                decimal average = 0;

                for (int i = lowerBound; i <= upperBound; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                        count++;
                    }
                }

                average = (decimal)sum / count;

                return average;
            }

            break;
        }
    case "11":
        {
            // Example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 11:");
            Console.WriteLine("*****************************");

            string[][] userEnteredValues = new string[][]
            {
                        new string[] { "1", "2", "3"},
                        new string[] { "1", "two", "3"},
                        new string[] { "0", "1", "2"}
            };

            try
            {
                Workflow1(userEnteredValues);
                Console.WriteLine("'Workflow1' completed successfully.");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("An error occurred during 'Workflow1'.");
                Console.WriteLine(ex.Message);
            }

            static void Workflow1(string[][] userEnteredValues)
            {

                foreach (string[] userEntries in userEnteredValues)
                {
                    try
                    {
                        Process1(userEntries);
                        Console.WriteLine("'Process1' completed successfully.");
                        Console.WriteLine();
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine("'Process1' encountered an issue, process aborted.");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                    }
                }
            }

            static void Process1(String[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    bool integerFormat = int.TryParse(userValue, out valueEntered);

                    if (integerFormat == true)
                    {
                        if (valueEntered != 0)
                        {
                            checked
                            {
                                int calculatedValue = 4 / valueEntered;
                            }
                        }
                        else
                        {
                            throw new DivideByZeroException("Invalid data. User input value must be  non-zero values");
                        }
                    }
                    else
                    {
                        throw new FormatException("Invalid data. User input values must be valid integers.");
                    }
                }
            }

            break;
        }
    case "12":
        {
            // Example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 12:");
            Console.WriteLine("*****************************");
            break;
        }
    case "13":
        {
            // Example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 13:");
            Console.WriteLine("*****************************");
            break;
        }
    case "14":
        {
            // Example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 14:");
            Console.WriteLine("*****************************");
            break;
        }
    case "15":
        {
            // Example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 15:");
            Console.WriteLine("*****************************");
            break;
        }
    case "16":
        {
            // Example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 16:");
            Console.WriteLine("*****************************");
            break;
        }
    case "17":
        {
            // Example
            Console.WriteLine("*****************************");
            Console.WriteLine("\tExample 17:");
            Console.WriteLine("*****************************");
            break;
        }
    default:
        {
            Console.WriteLine("Wrong input. Please try again");
            break;
        }
}
