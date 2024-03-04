using System.ComponentModel;

namespace homewrok6
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor a = new Professor();
            a.profName = "Alice";
            a.classTeach = "Java";
            a.SetSalary(9000);

            Professor b = new Professor();
            b.profName = "Bob";
            b.classTeach = "Math";
            b.SetSalary(8000);

            
            

            Student l = new Student();
            l.studnetName = "Lisa";
            l.classEnroll = "Java";
            l.SetGrade(90);

            Student t = new Student();
            t.studnetName = "Tom";
            t.classEnroll = "Math";
            t.SetGrade(80);

            Console.WriteLine("Professor " + a.profName + " teaches " + a.classTeach + " and the salary is: " + a.GetSalary() );
            Console.WriteLine("Professor " + b.profName + " teaches " + b.classTeach + " and the salary is: " + b.GetSalary() );
            Console.WriteLine("Student " + l.studnetName + " is enrolled in "  + l.classEnroll + " and the grade is: " + l.GetGrade() );
            Console.WriteLine("Student " + t.studnetName + " is enrolled in "  + t.classEnroll + " and the grade is: " + t.GetGrade() );
            Console.WriteLine("The salary diffrence between " + a.profName + " and " + b.profName + " is: " + (a.GetSalary() - b.GetSalary()) );
             Console.WriteLine("The total grade of " + l.studnetName + " and " + t.studnetName + " is: " + (l.GetGrade() + t.GetGrade()) );



        }
    class Professor
    {
        public string profName;
        public string classTeach;
        private double salary;
        public void SetSalary(double salary_amount)
        {
            salary = salary_amount;
        }
        public double GetSalary()
        {
            return salary;
        }
    }
    class Student
    {
        public string studnetName;
        public string classEnroll;
        private double studentGrade;
        public void SetGrade(double newGrade)
        {
            studentGrade = newGrade;
        }
        public double GetGrade()
        {
            return studentGrade;
        }
    }
}
}
