using System.ComponentModel;
using System.Runtime.InteropServices;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "blank";
            string answer = "blank";
            Console.WriteLine("Please enter the  letter grade: ");
            input = Console.ReadLine();
            //Preventing the Person inputing data from getting an error from entering a lower case
            answer = input.ToUpper();
            if (answer == "A")
            {
                Console.WriteLine("The GPA value is: 4");
            }
            else if (answer == "B")
            {
                Console.WriteLine("The GPA value is: 3");
            }
            else if (answer == "C")
            {
                Console.WriteLine("The GPA value is: 2");
            }
            else if (answer == "D")
            {
                Console.WriteLine("The GPA value is: 1");
            }
            else if (answer == "F")
            {
                Console.WriteLine("The GPA value is: 0");
            }
            else
            {
                Console.WriteLine("Please enter a valid Letter Grade");
                Console.WriteLine("Accepted Values: A, B, C, D, F");
            }


        }

    }
}
