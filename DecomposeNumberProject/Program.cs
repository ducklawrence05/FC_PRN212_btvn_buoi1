namespace DecomposeNumberProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 123;
            int hundreds;
            int tens;
            int ones;
            DecomposeNumber(123, out hundreds, out tens, out ones);

            Console.WriteLine($"----Decompose number: {number}----");
            Console.WriteLine("Hundreds: " + hundreds);
            Console.WriteLine("Tens    : " + tens);
            Console.WriteLine("Ones    : " + ones);
        }

        static void DecomposeNumber(int number, out int hundreds, out int tens, out int ones)
        {
            hundreds = number / 100 % 10;
            tens = number / 10 % 10;
            ones = number % 10;
        }
    }
}