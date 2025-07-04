// See https://aka.ms/new-console-template for more information
// Starting point
// Console.WriteLine("Hello, World!");

// Stateful methods or instance methods
// Must have access to the state of application to work
// Rely on values store in memory by previous lines that have been executed
Random dice = new Random();     // Instance of class = object
int roll = dice.Next(1, 7);     // Accessing method via object

// Another way to declare instance methods
Random dice2 = new();
int roll2 = dice2.Next(10, 70);

// Stateless methods or static methods.
// Doesn't rely on any values stored in memory
Console.WriteLine(roll);   
Console.WriteLine(roll2);   


                                
