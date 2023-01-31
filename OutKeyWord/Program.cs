namespace OutKeyWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int add;
            int mult;
            AddAndMultiply(5, 10, out add, out mult);
            Console.WriteLine(add);
            Console.WriteLine(mult);
        }

        private static void AddAndMultiply(int a, int b, out int added, out int multi)
        {
            added = a + b;
            multi = a * b;
        }
    }
}