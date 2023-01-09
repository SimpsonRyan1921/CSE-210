using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage in the class? ");
        string grade = Console.ReadLine();
        int x = int.Parse(grade);


        if (x > 90)
        {
            Console.Write("You have an A in the class.");
        }
        
        else if (x > 80)
        {
            Console.Write("You have a B in the class.");
        }
        else if (x > 70)
        {
            Console.Write("You have a C in the class.");
        }
        else if (x > 60)
        {
            Console.Write("You have a D in the class.");
        }
        else
        {
            Console.Write("You have failed the class.");
        }
    }
}