using System;
using System.Threading;

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
            NPC = "Rock";
            break;
          case 2:
            NPC = "Paper";
            break;
          case 3:
            NPC = "Scissors";
            break;
        }
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(NPC);
        Console.ForegroundColor = ConsoleColor.White;
        string playGame = "Rock, Paper, Scissors ... GO!";
        for (int i = 0; i < playGame.Length; i++)
        {
          Console.Write(playGame[i]);
          Thread.Sleep(15);
        }
        System.Console.WriteLine("");
        string guess = Console.ReadLine();
        if (guess.ToLower() == NPC.ToLower())
        {
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine("\nTie Game!");
          Console.ForegroundColor = ConsoleColor.White;
          draw++;
        }
        else if (
          (guess.ToLower() == "rock" && NPC.ToLower() == "scissors") ||
          (guess.ToLower() == "paper" && NPC.ToLower() == "rock") ||
          (guess.ToLower() == "scissors" && NPC.ToLower() == "paper"))
        {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("\nYou Win!");
          Console.ForegroundColor = ConsoleColor.White;
          win++;
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          if (NPC == "Scissors")
          {
            Console.WriteLine($"\n{NPC} beat {Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(guess)}");
          }
          else
          {
            Console.WriteLine($"\n{NPC} beats {Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(guess)}");
          }
          Console.WriteLine("You Lose.");
          Console.ForegroundColor = ConsoleColor.White;
          lose++;
        }
        Console.Write($"\nWin (");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(win);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(") | Lose (");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(lose);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(") | Draw (");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(draw);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(")");
        Console.WriteLine("\nPlay Again? [Y/N]");
        answer = Console.ReadLine().ToUpper();
      }
    }
  }
}
