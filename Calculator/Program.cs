Console.WriteLine("Hello! \nInput the first number: ");
string userinput = Console.ReadLine();
int num1 = int.Parse(userinput);

Console.WriteLine("Input the second number: ");
userinput = Console.ReadLine();
int num2 = int.Parse(userinput);

Console.WriteLine("What do you want to do with those numbers?\r\n[A]dd\r\n[S]ubtract\r\n[M]ultiply\r\n");
userinput = Console.ReadLine();
if (EqualCaseInsensitive(userinput,"A"))
{
    int result = num1 + num2;
    PrintFinalEquation(num1, num2, result, "+");
}
else if (EqualCaseInsensitive(userinput, "S"))
{
    int result = num1 - num2;
    PrintFinalEquation(num1, num2, result, "-");
}
else if (EqualCaseInsensitive(userinput, "M"))
{
    int result = num1 * num2;
    PrintFinalEquation(num1, num2, result, "*");
}
else
{
    Console.WriteLine("Invalid option");
}

void PrintFinalEquation(int number1, int number2, int equals, string @operator  )
{
    Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + equals);
}

bool EqualCaseInsensitive(string left, string right)
{
    return left.ToUpper().Equals(right.ToUpper());
}

Console.ReadKey();
