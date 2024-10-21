List <string> TasksToDo = new List<string>();

static void ShowNoTodosMessage()
{
    Console.WriteLine("No TODOs have been added yet.\n");
}

bool isprogrammrunning = true;
Console.WriteLine("Hello!");

do
{
    Console.WriteLine("What Do You Want to do?");
    Console.WriteLine("[S]ee all TODOS");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit\n");

    string userInput = Console.ReadLine();
    switch (userInput)
    {
        case "s":
        case "S":
            PrintSelectedOption("\nSee all TODOS");
            ShowAllTasksToDo(TasksToDo);
            break;
        case "a":
        case "A":
            PrintSelectedOption("\nAdd a TODO");
            AddATODO();
            break;
        case "r":
        case "R":
            PrintSelectedOption("\nRemove a TODO");
            RemoveATODO();
            break;
        case "e":
        case "E":
            PrintSelectedOption("\nExit\n");
            isprogrammrunning = false;
            break;
        default:
            PrintSelectedOption("\nIs not valid\n");
            break;
    }
} while (isprogrammrunning);

Console.WriteLine("\nThanks for Using, Goodbye!\nMade by: Ruslan Makhanov");
Console.ReadKey();

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("\nSelected Option: " + selectedOption);
}

void ShowAllTasksToDo(List <string> tasks)
{
    Console.WriteLine("-----------------------");
    int taskcount = 0;
    if (tasks.Count == 0)
    {
        ShowNoTodosMessage();
    }
    foreach (string task in tasks)
    {
        Console.WriteLine("Task " + ++taskcount+ ": " + task);
    }
}

void AddATODO()
{
    bool DescriptionIsValid = false;
    do { 
        Console.WriteLine("Enter a TODO Description: ");
        string ToDoDescription = Console.ReadLine();
        if (TasksToDo.Contains(ToDoDescription))
        {
            Console.WriteLine("The description must be unique!\n");
        }
        else if (ToDoDescription.Length > 0)
        {
            Console.WriteLine("Task has been added");
            TasksToDo.Add(ToDoDescription);
            DescriptionIsValid = true;
        }
        else 
        {
            Console.WriteLine("The description cannot be empty.\n");
        }
    }while (!DescriptionIsValid);

}
void RemoveATODO(){
    bool isParsingSuccessful;
    int AmountOfTasks = TasksToDo.Count();
    if (AmountOfTasks > 0) 
    {
        do { 
            ShowAllTasksToDo(TasksToDo);
            Console.WriteLine("Which Task Would You like to Remove? \n");
            string userinput = Console.ReadLine();
            isParsingSuccessful = int.TryParse(userinput, out int number);
            if (userinput == null)
            {
                Console.WriteLine("Selected index cannot be empty.");
            }
            else if (AmountOfTasks < number || !isParsingSuccessful)
            {
                Console.WriteLine("The given index is not valid.");
                isParsingSuccessful = false;
            }
            else
            {
                Console.WriteLine("TODO removed: " + TasksToDo[number - 1]);
                TasksToDo.RemoveAt(number-1);
            }
        }while (!isParsingSuccessful);
    }
    else
    {
        ShowNoTodosMessage();
    }
}