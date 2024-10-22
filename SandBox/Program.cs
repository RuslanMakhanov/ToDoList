var medicalAppointment = new MedicalAppointment(
    "John Smith", new DateTime(2023, 4, 3));
var medicalAppointment1 = new MedicalAppointment("Jogn");
var medicalAppointment2 = new MedicalAppointment(2);

medicalAppointment.OverrideMonthAndDay(5, 1);

medicalAppointment.MoveByMonthAndDay(1, 2);

Console.WriteLine("Methods_Overloading");
Console.ReadKey();


var rectangle = new Rectangle(5, 10);
var calculator = new ShapeMeasurmentsCalculator();

Console.WriteLine("The rectangle width: " + rectangle.Width);
Console.WriteLine("The rectangle height: " + rectangle.Height);
Console.WriteLine("Area is: " + rectangle.CalculateArea());
Console.WriteLine("Circumference is: " + rectangle.CalculateCircumference());

Console.WriteLine("Area is: " + calculator.CalculateRectangleCircumference(rectangle));
Console.WriteLine("Circumference is: " + calculator.CalculateRectangleArea(rectangle));

//bool isParsingSuccessful;
//do
//{
//    Console.WriteLine("Please enter a number");
//    var userinput = Console.ReadLine();
//    isParsingSuccessful = int.TryParse(userinput, out int number);
//    if (isParsingSuccessful)
//    {
//        Console.WriteLine("Parsing worked, number is: " + number);
//    }
//} while (!isParsingSuccessful);

//var numbers = new[]
//{
//    -1,2,-3,4,5,6,-7,8,9,-10
//};
//int negativenumbers;
//var onlypositive = GetOnlyPositive(numbers, out negativenumbers);
//foreach (int positive in onlypositive)
//{
//    Console.WriteLine(positive);
//}
//List<int> GetOnlyPositive(int[] nums, out int countNonPositive)
//{
//    countNonPositive = 0;
//    var result = new List<int>();
//    foreach (int num in nums)
//    {
//        if (num > 0)
//        {
//            result.Add(num);
//        }
//        else
//        {
//            countNonPositive++;
//        }
//    }
//    return result;
//}

//Console.ReadKey();

//string word;
//do
//{
//    Console.WriteLine("Enter a word longer than 10 letters");
//    word = Console.ReadLine();
//}
//while (word.Length <=10);
//var letter = new char[,]
//{
//    { 'A', 'B', 'C' },
//     { 'D', 'E', 'F' }
//};
//for (int i = 0; i < letter.GetLength(0); i++)
//{
//    for (int j = 0; j < letter.GetLength(1); j++)
//    {
//        Console.WriteLine(letter[i, j]);
//    }
//}

//List <string> words = new List<string>();
//Console.WriteLine("Count of elements is " +words.Count); //to count amount of words use Count
//words.Add("Hello");
//Console.WriteLine("Count of elements is " + words.Count);

//var words = new List<string>
//{
//    "one",
//    "two",
//};
//Console.WriteLine(words.Contains("one"));
//foreach (string word1 in words)
//{
//    Console.WriteLine($"{word1}");
//}
//words.Remove("one");
//Console.WriteLine(words.Contains("one"));
//foreach (string word1 in words)
//{
//    Console.WriteLine($"{word1}");
//}
//words.RemoveAt(0);
//words.Add("three");
//foreach (string word1 in words)
//{
//    Console.WriteLine($"{word1}");
//}
//Console.WriteLine(words.Contains("one"));
//Console.WriteLine("Before printing all words");
//words.Clear();
//foreach (string word1 in words)
//{
//    Console.WriteLine($"{word1}");
//}
//Console.WriteLine("Printed all words");


//if (userInput == "S")
//{
//    PrintSelectedOption("See all TODOS");
//}
//else if (userInput == "A")
//{
//    PrintSelectedOption("Add a TODO");
//}
//else if (userInput == "R")
//{
//    PrintSelectedOption("Remove a TODO");
//}
//else if (userInput == "E")
//{
//    PrintSelectedOption("Exit");
//}
//else
//{
//    PrintSelectedOption("Is not valid");
//}