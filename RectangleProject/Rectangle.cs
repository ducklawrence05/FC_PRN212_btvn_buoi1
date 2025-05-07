using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProject
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalcPerimeter()
        {
            return (Length + Width) * 2;
        }

        public double CalcArea()
        {
            return Length * Width;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Length: " + Length);
            Console.WriteLine("Width : " + Width);
        }
    }
}
