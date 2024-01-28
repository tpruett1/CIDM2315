namespace bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            Console.WriteLine("Please Enter a Year: ");
            year = Convert.ToInt16(Console.ReadLine());
            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        Console.WriteLine(year + " is a Leap Year");
                    }
                    else{
                        Console.WriteLine(year + " is not a Leap Year");
                    }
                }
                else
                {
                    Console.WriteLine(year + " is a Leap Year");
                }
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year");
            }

        }
    }
}