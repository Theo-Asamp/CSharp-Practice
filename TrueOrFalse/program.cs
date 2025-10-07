using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
    
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      string[] questions = {"The sky is Blue", "1+1=4","everyone is male"};
      bool[] answers = {true, false, false};
      bool[] responses = new bool[3];

      if(questions.Length != answers.Length)
      {
        Console.WriteLine("Warning code error");
      }

      int askingIndex = 0;

      foreach(string question in questions)
      {
        string input;
        bool isBool = false;
        bool inputBool = false;

        Console.WriteLine(question);
        Console.WriteLine("True or False?");
        input = Console.ReadLine().ToLower();
        if (input == "true" || input =="false")
        {
          isBool = true;
        }
        else
        {
          isBool = false;
        }

        while(isBool == false)
        {
          Console.WriteLine("Please respond with 'true' or 'false'");
          input = Console.ReadLine().ToLower();
          if (input == "true" || input =="false")
          {
            isBool = true;
          }
          else
          {
            isBool = false;
          }
        }
        if(input == "true")
        {
          inputBool = true;
        }
        else if(input == "false")
        {
          inputBool = false;
        }
        
        responses[askingIndex] = inputBool;
        askingIndex++;
      }

      foreach(bool resp in responses)
      {
        Console.WriteLine(resp);
      }

      int scoringIndex = 0;
      int score = 0;

      foreach(bool answer in answers)
      {
        bool scores = responses[scoringIndex];
        Console.WriteLine($"Input:{scores}|Answer:{answer}");
        if (answer == scores)
        {
          score++;
        }
        scoringIndex++;
      }
      Console.WriteLine($"You got {score} of of 3 correct!");
      
    }
  }
}
