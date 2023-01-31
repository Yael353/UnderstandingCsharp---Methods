namespace ParamArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 5, 6, 7, 8, 9, 10 };
            PrintArray(myArray);
            PrintArray(5, 6, 7, 8, 9, 10);
        }
        public static void PrintArray(params int[] array) // params allows me to build n
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}