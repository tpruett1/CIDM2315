namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int lines = 0;
            int colums = 0;
            var clear = false;
            Console.WriteLine("Assign a value to N:");
            n = Convert.ToInt16(Console.ReadLine());
            while(n>lines)
            {
                while(n>colums)
                {
                    Console.Write("#");
                    colums++;
                    if(n==colums)
                    {
                        clear = true;
                    }
                }
                Console.WriteLine();
                lines++;
                if(clear)
                {
                    colums=0;
                }
                
                
                
            }


        }
    }
}