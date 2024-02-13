using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Transactions;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            //directory
            string input = "blank";
            Console.WriteLine("Please Choose one of the Selections Below");
            Console.WriteLine("Input2");
            Console.WriteLine("Input4");
            Console.WriteLine("Account");
            input = Console.ReadLine();
            input = input.ToUpper();
            if(input.Equals("INPUT2"))
            {
                Input2();
            }
            else if(input.Equals("INPUT4"))
            {
                Input4();
            }
            else if(input.Equals("ACCOUNT"))
            {
                Account();
            }
        }
        static void Input2()
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Please enter a Number");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter another Number");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("a = " + a + "; b = " + b );
            Console.WriteLine("The largest number is: " + Compare(a,b));
        }
        static int Compare(int alpha , int beta)
        {
            int max = 0;
            if(alpha > beta)
            {
                max = alpha;
            }
            else
            {
                max = beta;

            }
            return max;
        }
        static void Input4()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            Console.WriteLine("Please enter a Number");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter another Number");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter another Number");
            c = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter another Number");
            d = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("a = " + a + "; b = " + b + "; c = " + c +"; d = " + d);
            int max1 = Compare(a,b);
            int max2 = Compare(c,d);
            Console.WriteLine("The largest number is: " + Compare(max1,max2));

        }
        static void Account()
        {
            string username = "blank";
            string password = "blank";
            string password2 = "blank";
            int birthyear = 0;
            bool checkpass = false;
            bool yearpass= false;
            Console.WriteLine("Enter Your Username");
            username = Console.ReadLine();
            Console.WriteLine("Please Enter Your Password");
            password = Console.ReadLine();
            Console.WriteLine("Plesae Enter Your Password Again");
            password2 = Console.ReadLine();
            Console.WriteLine("Plesae Enter the Year You Were Born");
            birthyear = Convert.ToInt16(Console.ReadLine());
            checkpass = CheckPassword(password,password2);
            yearpass = CheckAge(birthyear);
            if(checkpass && yearpass)
            {
                Console.WriteLine("Account Created Successfully");
            }
            else if(!yearpass)
            {
                Console.WriteLine("Unable to Create an Account");
            }
            else
            {
                Console.WriteLine("Wrong Password");
            }
            
        }
        static bool CheckAge(int age)
        {
            if(2024 - age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool CheckPassword(string pass, string passcheck)
        {
            if(pass.Equals(passcheck))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}