namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int lines = 1;
            int colums = 0;
            var clear = false;
            Console.WriteLine("Assign a value to N:");
            n = Convert.ToInt16(Console.ReadLine());
            while(n>=lines)
            {

                while(lines>colums)
                {
                    Console.Write("*");
                    colums++;

                    if(lines==colums)
                    {
                        clear=true;
                    }
                }

                lines++;
                Console.WriteLine();
                if(clear)
                {
                    colums=0;
                }
                
                
                
            }


        }
    }
}