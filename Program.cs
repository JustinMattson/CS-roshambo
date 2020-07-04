using System;

namespace roshambo
{
  class Program
  {
    static void Main(string[] args)
    {
      string answer = "Y";
      int win = 0;
      int lose = 0;
      int draw = 0;
      while (answer == "Y")
      {
        Console.Clear();
        Random random = new Random();
        int rand = random.Next(1, 4);
        string NPC = "";
        switch (rand)
        {
          case 1:
            NPC = "rock";
            break;
          case 2:
            NPC = "paper";
            break;
          case 3:
            NPC = "scissors";
            break;
        }
        Console.WriteLine(NPC);
        Console.WriteLine("Rock, Paper, Scissors ... GO!");
        string guess = Console.ReadLine().ToLower();
        if (guess == NPC)
        {
          Console.WriteLine("Tie Game!");
          draw++;
        }
        else if ((guess == "rock" && NPC == "scissors") || (guess == "paper" && NPC == "rock") || (guess == "scissors" && NPC == "paper"))
        {
          Console.WriteLine("You Win!");
          win++;
        }
        else
        {
          Console.WriteLine("You Lose.");
          lose++;
        }
        Console.WriteLine($"Win ({win}) | Lose ({lose}) | Draw ({draw})");
        Console.WriteLine("\nPlay Again? [Y/N]");
        answer = Console.ReadLine().ToUpper();
      }
    }
  }
}
