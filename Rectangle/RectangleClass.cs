using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleClass
{
    public class Rectangle
    {
        const int NumberOfSides = 4;
        readonly int NumberOfSidesReadonly;
        public int Width = 3;
        public int Height = 9;
        public static int GetOne() => 1;

        public Rectangle(int width, int height)
        {
            Width = GetLengthOrDefault(width, nameof(Width));
            Height = GetLengthOrDefault(height, nameof(Height));
        }
        private int GetLengthOrDefault(int length, string name)
        {
            const int DefaultValueIfNonPositive = 1;
            if (length <= 0)
            {
                Console.WriteLine($"{name} must be a positive number.");
                return DefaultValueIfNonPositive;
            }
            return length;
        }
        public int CalculateCircumference() => 2 * Width + 2 * Height;
        public int CalculateArea() => Width * Height;
    }

    public class ShapeMeasurmentsCalculator
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
}
