var medicalAppointment = new MedicalAppointment(
    "John Smith", new DateTime(2023, 4, 3));

medicalAppointment.OverrideMonthAndDay(5, 1);

medicalAppointment.MoveByMonthAndDay(1, 2);

Console.WriteLine("Methods_Overloading");
Console.ReadKey();


var rectangle = new Rectangle(5,10);
var calculator = new ShapeMeasurmentsCalculator();

Console.WriteLine("The rectangle width: " + rectangle.Width);
Console.WriteLine("The rectangle height: " + rectangle.Height);
Console.WriteLine("Area is: " + rectangle.CalculateArea());
Console.WriteLine("Circumference is: " + rectangle.CalculateCircumference());

Console.WriteLine("Area is: " + calculator.CalculateRectangleCircumference(rectangle));
Console.WriteLine("Circumference is: " + calculator.CalculateRectangleArea(rectangle));


//rectangle.Width = 7; 
//rectangle.Height = -5;

//Console.WriteLine("The rectangle width: " + rectangle.Width);
//Console.WriteLine("The rectangle height: " + rectangle.Height);

//var rectangle2 = new Rectangle(2,3);

//Console.WriteLine("The rectangle2 width: " + rectangle2.Width);
//Console.WriteLine("The rectangle2 height: " + rectangle2.Height);

//var rectangle3 = new Rectangle();

//Console.WriteLine("The rectangle3 width: " + rectangle3.Width);
//Console.WriteLine("The rectangle3 height: " + rectangle3.Height);

Console.ReadKey();

class Rectangle
{
    public int Width = 3;
    public int Height = 9;

    public Rectangle(int width, int height) 
    {
        Width = width;
        Height = height;
    }
    public int CalculateCircumference()
    {
        return 2 * Width + 2 * Height;
    }
    public int CalculateArea()
    {
        return Width * Height;
    }
}

class ShapeMeasurmentsCalculator
{
    public int CalculateRectangleCircumference(Rectangle rectangle)
    {
        return 2 * rectangle.Width + 2 * rectangle.Height;
    }
    public int CalculateRectangleArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}







//var internationalPizzaDay23 = new DateTime(2023, 2, 9, 12, 34, 11);

//Console.WriteLine("Year is " + internationalPizzaDay23.Year);
//Console.WriteLine("Month is " + internationalPizzaDay23.Month);
//Console.WriteLine("Day is " + internationalPizzaDay23.Day);
//Console.WriteLine("Day of the week is: " + internationalPizzaDay23.DayOfWeek);

//Console.ReadKey();

//var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

//Console.WriteLine("Year is " + internationalPizzaDay24.Year);
//Console.WriteLine("Month is " + internationalPizzaDay24.Month);
//Console.WriteLine("Day is " + internationalPizzaDay24.Day);
//Console.WriteLine("Day of the week is: " + internationalPizzaDay24.DayOfWeek);

//Console.ReadKey();
