namespace Exercise1
{
    internal class Program
    {
        //Exercise1
        //Create a program that asks the user for an integer and then calls
        //a method named multiplication table(), which displays the results
        //of multiplying the integer by each of the numbers 2 trough 10. 


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome yo this multiplication table! Enter an integer.");
            int input = int.Parse(Console.ReadLine());


            MultiplicationTable(input);
        }
        public static void MultiplicationTable(int input)
        {
            int[] multiTable = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int answer = 0;


            for (int i = 0; i < multiTable.Length; i++)
            {
                answer = input * multiTable[i];
                Console.WriteLine($"{input,2} * {multiTable[i],2} = {answer,2}");
            }

            // Easier solution:
            //for (int i = 2; i <= 10; i++)
            //{
            //    int answer = input * i;
            //    Console.WriteLine($"{input,2} * {i,2} = {answer,2}");
            //}
        }
    }
}