using RectangleClass;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var rectangle2 = new Rectangle(2, 3);

        Console.WriteLine("The rectangle2 width: " + rectangle2.Width);
        var rectangle3 = new Rectangle(-1, -2);

        Console.WriteLine("The rectangle2 width: " + rectangle2.Width);

        var rectangle = new Rectangle(5, 10);
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

        //Console.ReadKey();

        Console.WriteLine("The rectangle width: " + rectangle.Width);
        Console.WriteLine("The rectangle height: " + rectangle.Height);
        Console.WriteLine("Area is: " + rectangle.CalculateArea());
        Console.WriteLine("Circumference is: " + rectangle.CalculateCircumference());

        var calculator = new ShapeMeasurmentsCalculator();
        Console.WriteLine("Area is: " + calculator.CalculateRectangleCircumference(rectangle));
        Console.WriteLine("Circumference is: " + calculator.CalculateRectangleArea(rectangle));

    }
}