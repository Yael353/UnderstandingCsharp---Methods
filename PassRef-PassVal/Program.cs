namespace PassRef_PassVal
{
    internal class Program //Reference type
                           //int, string, double etc are value types.
    {
        //lecture 42: Pass by reference / value
        static void Main(string[] args)
        {
            //pass means giving information trough arguments

            //Pass by value:
            int student1Grade = 75;
            Console.WriteLine($"Students grade BEFORE extra credit {student1Grade}");
            GiveExtraCredit(student1Grade);
            Console.WriteLine($"Students grade BACK TO BEFORE extra credit {student1Grade}");


            //Pass by reference:
            int[] grades = new int[1]; //"New" says that it is a class which makes it a reference type
            grades[0] = 75;
            Console.WriteLine("Student array grade BEFORE extra credit {0}", grades[0]);

            GiveExtraCreditArray(grades);
            Console.WriteLine("Student array grade AFTER extra credit {0}", grades[0]);

            // By passing in a reference the location itself gets passed in as an argument
            // But when you pass in a value it only gets passed in as a copy.
            // The reason for that is the "New", which creates a new memory 
        }
        public static void GiveExtraCredit(int studentGrade)
        {
            studentGrade += 3;
            Console.WriteLine("Students grade after extra credit {0}", studentGrade);
        }
        public static void GiveExtraCreditArray(int[] grades)
        {
            grades[0] += 3; 
        }
    }
}