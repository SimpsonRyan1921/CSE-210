using System;

class Program
{
    static void Main(string[] args)
    {
      int journalChoices = 1;

      while(journalChoices == 1)
      {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
        string userChoice = Console.ReadLine();
        int userNumChoice = int.Parse(userChoice);

        
        if (userNumChoice == 1)
        {
          PromptGenerator writersPrompt = new PromptGenerator();
          string prompt = writersPrompt.GeneratePrompt();
          Console.WriteLine(writersPrompt); 
          
          Entry entry = new Entry();


        }
        else if(userNumChoice == 2)
        {

        }
        
        else if(userNumChoice == 3)
        {

        }

        else if(userNumChoice == 4)
        {

        }

        else if(userNumChoice == 5)
        {

        }
        
      }

    }
}