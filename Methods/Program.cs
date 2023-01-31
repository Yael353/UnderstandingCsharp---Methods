using System.IO.Pipes;

namespace Methods
{
    internal class Program
    {
        //Lecture 41. Creating a method.

        static void Main(string[] args)
        {
           int answer = Add(10, 20);
            Console.WriteLine(answer);
            int secondAnswer = Add(answer, 20);
            Console.WriteLine(secondAnswer);
            int a = int.Parse("Test");


        }
        //public: anyone can use it, console.WriteLine is public
        //private: Only this class can use it.

        public static int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }
    }
}