using System.Data;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            var prime = true;
            Console.WriteLine("Input an integer:");
            n = Convert.ToInt16(Console.ReadLine());
            for(var i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
                
                }
            if (prime)
            {
                Console.WriteLine("The number Entered is Prime");
            }
            else
            {
                Console.WriteLine("The number Entered is Not Prime");
            }

            }
        }
    }