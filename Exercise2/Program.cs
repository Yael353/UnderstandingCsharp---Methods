using System.Reflection.Metadata.Ecma335;

namespace Exercise2
{
    internal class Program
    {
        //Exercise2

        //promt for an integer,
        //pass the value to a method that squares and a method that cubes  the number.
        //the cube method should call the square method.
        //the main method displays the results returned from each of the other methods
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number that you would like to square and cube");
            int number = int.Parse(Console.ReadLine());
            
            int squared = Square(number);
            int cubed = Cube(number);

            Console.WriteLine($"{number} squared is {squared}");
            Console.WriteLine($"{number} cubed is {cubed}");
        }
        public static int Square(int number)
        {
            int answer = number * number;
            return answer;
        }
        public static int Cube(int number)
        {
            int answer = Square(number) * number;
            return answer;
        }
    }
}