namespace OptionalParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add(5);
            Add(5,5);
            Add2(5, z : 5);
        }
        public static void Add(int x, int y = 1) // Y = 1 makes y optional, it also work as default.
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }public static void Add2(int x, int y = 1, int z = 2) // z : = changes the order, in this case we skipp param y
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }
    }
}