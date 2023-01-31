using System.Runtime.InteropServices;

namespace Exercise3
{
    internal class Program
    {
        //Exercise3

        //Create a method named Sum() that accepts any number of integer parameters and displays their sum.
        //write a main() method that demonstrates that the Sum() method works correctly
        //when passed one three or five integers or an array of then integers

        static void Main(string[] args)
        {
            //Specify an amount of integers
            Sum(5);
            Sum(5, 10, 15);
            Sum(5, 10, 15, 20, 25);
            int[] myArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
            Sum(myArray);
            
        }
        //Create a method that sums the amount of integers
        public static void Sum(params int[] myArray)
        {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }   
}