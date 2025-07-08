// Contoso Pets Application
// Data to be store in ourAnimals array:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// Variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// Array to store runtime data
string[,] ourAnimals = new string[maxPets, 6];

//TODO: Convert the if-else construct to a switch statement

// Create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    // Select data
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:

            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained";
            animalPersonalityDescription = "friendly and loving cat. love to drop vases";
            animalNickname = "kitty";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "3";
            animalPhysicalDescription = "medium black and white male weighin 14 pounds.";
            animalPersonalityDescription = "playful and good rat hunter";
            animalNickname = "hunter";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    // Load data into array that acts a database
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// Display menu
do
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu option are:");
    Console.WriteLine("  1. List all of our current pet information");
    Console.WriteLine("  2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine("  3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine("  4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine("  5. Edit an animal's age");
    Console.WriteLine("  6. Edit an animal's personality description");
    Console.WriteLine("  7. Display all cats with a specified characteristic");
    Console.WriteLine("  8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("  Press enter to continue or type \"exit\" to quit.");  // Verbatim string used and need double quote on double quote

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
        // Console.WriteLine($"You have selected menu option {menuSelection}");
    }

    //pause code execution
    //readResult = Console.ReadLine();

    switch (menuSelection)
    {
        case "1":
            
            break;

        case "2":

            break;

        case "3":

            break;

        case "4":

            break;

        case "5":

            break;

        case "6":

            break;

        case "7":

            break;

        case "8":

            break;

        default:

            break;  

    }

} while (menuSelection != "exit");

