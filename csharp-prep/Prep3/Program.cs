using System;

class Program
{
    static void Main(string[] args)
    {
       int gameOn = 1;

       int guesses = 1;

       while (gameOn == 1)
       {
        Random rnd = new Random();
        int magic = rnd.Next(0, 100); 
        
        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int answer = int.Parse(userInput);

        while (answer != magic)
        {
            if (answer > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (answer < magic)
            {
                Console.WriteLine("Higher");
            }
            guesses += 1;
            Console.Write("Guess again? ");
            userInput = Console.ReadLine();
            answer = int.Parse(userInput);
        }

        Console.WriteLine($"You got it in {guesses} guesses!");

        Console.Write("Would you like to play again(Y/N)? ");
        string again = Console.ReadLine();
        if (again == "Y")
        {
            gameOn = 1;
        }    
        else
        {
            gameOn = 0;
            Console.Write("Thank you for playing!");
        }
       }
    }
}