using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Homework4
{
    class Program
    {


    static void Main(string[] args)
    {
        string input = "blank";
        Console.WriteLine("Would you like to compare numbers or make shapes?");
        Console.WriteLine("Please Enter compare or shapes");
        input = Console.ReadLine();
        input = input.ToUpper();
        
        if(input.Equals("COMPARE"))
        {
            Largest();
        }
        else if (input.Equals("SHAPES"))
        {
            Shapes();
        }
        //put shapes
        else
        {
            Console.WriteLine("Please try again and enter a valid choice");

        }

    }
//Q1
    static void Largest()
    {
        int a = 0;
        int b = 0;
        Console.WriteLine("Please input a number");
        a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please Input another Number");
        b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("a = " + a + "; b = " + b);
        if(a>b)
        {
            Console.WriteLine("The largest Number is: " + a);
        }
        else if (b>a)
        {
            Console.WriteLine("The largest number is: " + b);
        }
        else
        {
            Console.WriteLine("The numbers are equal");
        }
    }


//Q2
    static void Shapes()
    {
        string shape = "blank";
        Console.WriteLine("Please choose a side");
        Console.WriteLine("Please Enter right or left");
        shape = Console.ReadLine().ToUpper();
        if(shape.Equals("RIGHT"))
        {
            Right();
        }
        else if(shape.Equals("LEFT"))
        {
            Left();

        }
        else
        {
            Console.WriteLine("Please try again with a correct input");

        }
    

    
    static void Left()
    {
        int size = 0;
        int colum = 1;
        int count = 0;
        Console.WriteLine("Please Enter a Number");
        size = Convert.ToInt16(Console.ReadLine());
        while(size>=colum)
        {
            while(colum>count)
            {
                Console.Write("*");
                count++;
            }
            if(colum==count)
            {
                count = 0;
            }

            Console.WriteLine();
            colum++;

        }


    }
    static void Right()
    {
        int size = 0;
        int colum = 1;
        int count = 0;
        int space = 0;
        int initial = 0;
        Console.WriteLine("Please Enter a Number");
        size = Convert.ToInt16(Console.ReadLine());
        initial = size - 1;
        while(size>=colum)
        {
            while(colum>count)
            {
            while(initial>space)
            {
                Console.Write(" ");
                space++;

            }
            Console.Write("*");
            count++;
            }
            if (colum==count)
            {
                count = 0;
            }
             if(space==initial)
            {
            initial--;
            space = 0;
            }
            Console.WriteLine();
            colum++;
        }
    }
    }
    }
}


