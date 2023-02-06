using System;

public class PromptGenerator
{
    public string GeneratePrompt()
    {
        string[] promptsList = {
            "What was the favorite part of your day?",
            "How did you grow today?",
            "Who have you helped today?"
            };


        Random rnd = new Random();
        int index = rnd.Next(0, promptsList.Length);
        string selectPrompt = promptsList[index];

        return selectPrompt;

    }

}