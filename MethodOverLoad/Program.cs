using System.ComponentModel;

namespace MethodOverLoad
{
    //Lecture 49: Method Overload
    internal class Program
    {
        static void Main(string[] args)
        {
            Add(5, 6);
            Add(5.5, 6.6);
            Add("Hello", "World!");
        }
        public static void Add(int x, int y) // If 
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }
        public static void Add(string x, string y)
        {
            string answer = x + " " + y;
            Console.WriteLine(answer);
        }
        public static void Add(double x, double y)
        {
            double answer = x + y;
            Console.WriteLine(answer);
        }
    }
}