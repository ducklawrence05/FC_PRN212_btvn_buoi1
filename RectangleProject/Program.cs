namespace RectangleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle1 = new Rectangle(3.14, 421);
            Console.WriteLine("Perimeter: " + rectangle1.CalcPerimeter());
            Console.WriteLine("Area: " + rectangle1.CalcArea());
            rectangle1.ShowInfo();
        }
    }

}