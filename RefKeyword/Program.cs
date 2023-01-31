namespace RefKeyword
{
    internal class Program
    {
        //lecture 43: Ref keyword
        static void Main(string[] args)
        {
            int studentGrade = 75;
            GiveExtraCredit(ref studentGrade); //Passing by reference allows you to make changes inside the function.
                                               // must also type ref as an argument like bellow.
            Console.WriteLine(studentGrade);

        }
        public static void GiveExtraCredit(ref int studentGrade)
        { 
            studentGrade += 3; 
        }

    }
}