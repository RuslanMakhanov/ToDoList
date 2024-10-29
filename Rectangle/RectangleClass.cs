using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleClass
{
    public class Rectangle
    {
        private int _width = 3;
        private int _height = 9;
        public int Height
        {
            get { return _height; }
            set 
            {
                if (_height > 0)
                {
                    _height = value;
                }
            }
        }
        public int Width
        {
            get { return _width; }
            set
            {
                if ( Width > 0)
                {
                    _width = value;
                }
            } 
        }

        public int GetHeight() => _height;
        public void SetHeight( int value)
        {
            if (value >0)
            {
                _height = value; 
            }
        }

        public Rectangle(int width, int height)
        {
            _width = GetLengthOrDefault(width, nameof(_width));
            _height = GetLengthOrDefault(height, nameof(_height));
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
        public int CalculateCircumference() => 2 * _width + 2 * _height;
        public int CalculateArea() => _width * _height;
        public string Description => $"A rectangle with width {Width} " +
            $"and height {Height}";
    }

    public class ShapeMeasurmentsCalculator
    {
        public int CalculateRectangleCircumference(Rectangle rectangle)
        {
            return 2 * rectangle.Width + 2 * rectangle.GetHeight();
        }
        public int CalculateRectangleArea(Rectangle rectangle)
        {
            return rectangle.Width * rectangle.GetHeight();
        }
    }
}
