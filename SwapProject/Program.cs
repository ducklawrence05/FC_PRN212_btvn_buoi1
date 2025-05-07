namespace SwapProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine("----Before swap----");
            Console.WriteLine(a + " " + b);

            Console.WriteLine("----After swap----");
            Swap(ref a, ref b);
            Console.WriteLine(a + " " + b);
        }

        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}