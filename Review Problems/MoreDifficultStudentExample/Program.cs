using System;

namespace MoreDifficultStudentExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter a number");
            //double x = Convert.ToDouble(Console.WriteLine());

            Student myStudent = new Student(5, "Robert", "Young", 150000);
            Console.WriteLine(myStudent);

            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);

            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);

            

            try
            {
                myStudent.MakePayment(500);
                Console.WriteLine(myStudent);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

        }
    }
}
