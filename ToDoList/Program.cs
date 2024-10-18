Console.WriteLine("What Do You Want?");
Console.WriteLine("[S]ee all TODOS");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userInput = Console.ReadLine();
switch (userInput)
{
    case "s":
    case "S":
        PrintSelectedOption("See all TODOS");
        break;
    case "a":
    case "A":
        PrintSelectedOption("Add a TODO");
        break;
    case "r":
    case "R":
        PrintSelectedOption("Remove a TODO");
        break;
    case "e":
    case "E":
        PrintSelectedOption("Exit");
        break;
    default:
        PrintSelectedOption("Is not valid");
        break;
}

Console.ReadKey();

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected Option: " + selectedOption);
}