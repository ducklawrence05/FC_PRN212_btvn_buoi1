namespace CalculateProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 24;

            int sum, difference, product;
            double quotient;
            
            Calculate(a, b, out sum, out difference, out product, out quotient);

            Console.WriteLine($"----Calculate between {a} and {b}----");
            Console.WriteLine("Sum       : " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product   : " + product);
            Console.WriteLine("Quotient  : " + quotient);
        }

        static void Calculate(
            int a, int b,
            out int sum, out int difference,
            out int product, out double quotient)
        {
            sum = a + b;
            difference = a - b;
            product = a * b;
            quotient = b != 0 ? (double)a / b : 0;
        }
    }
}