Console.WriteLine("What Do You Want?");
Console.WriteLine("[S]ee all TODOS");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userInput = Console.ReadLine();

if (userInput == "S")
{
    PrintSelectedOption("See all TODOS");
}
else if (userInput == "A")
{
    PrintSelectedOption("Add a TODO");
}
else if (userInput == "R")
{
    PrintSelectedOption("Remove a TODO");
}
else if (userInput == "E")
{
    PrintSelectedOption("Exit");
}
else
{
    PrintSelectedOption("Is not valid");
}

Console.ReadKey();

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected Option: " + selectedOption);
}