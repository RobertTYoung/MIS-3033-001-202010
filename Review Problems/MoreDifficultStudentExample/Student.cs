using System;
using System.Collections.Generic;
using System.Text;

namespace MoreDifficultStudentExample
{
    class Student
    {
        //hold alt + shift, use arrow keys to selct lines
        //
        public int SoonerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }
        private double BursarBalance { get; set; }

        //Default Constructor for the student
        public Student()
        {
            SoonerID = -1;
            FirstName = string.Empty;
            LastName = "";
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 10000;
        }

        public Student(int id, string fName, string lName, double BursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }

        public void MakePayment(double amount)
        {
            if (amount > 0)
            {
                BursarBalance = BursarBalance - amount;
            }
            else
            {
                throw new Exception("INVALID PAYMENT AMOUNT");
            }
        }

        public double CheckBalance()
        {
            return BursarBalance;
        }

        public override string ToString()
        { 
            string result = $"{FirstName} {LastName} ({SoonerID}) has s {GPA.ToString("N2")} GPA and owes {BursarBalance.ToString("C")}";
            if (IsOnProbation == true)
            {
                result += "\n Is on Probation.";
            }
            else
            {
                result += "\n Is not on Probation.";
            }

            return result;
        }
    }
}
