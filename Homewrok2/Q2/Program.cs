namespace q2
{
class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 2;
            int third = 3;
            Console.WriteLine("Please input the first num: ");
            first = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please input the second num: ");
            second = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please input the third num: ");
            third = Convert.ToInt16(Console.ReadLine());
            if (first > second) 
            {
                if(second > third)
                {
                    Console.WriteLine("The smallest value is: " + third);
                }
                else
                {
                    Console.WriteLine("The smallest value is: " + second);
                }
            }
            else if (second > first)
            {
                if (first > third)
                {
                    Console.WriteLine("The smallest value is: " + third);
                }
                else
                {
                    Console.WriteLine("The smallest value is: " + first);
                }
            }
            else
            {
                Console.WriteLine("Multiple values are the same please reenter and try again. ");
            }

         }
    }
}