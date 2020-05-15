using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hey there, I can take a sentence and a word, and I can count how many times that word appears in that sentence");

      bool view = false;

      while (!view)
      {
        view = RunProgramLoop();
      }

      if (view == true)
      {
        EndProgram();
      }
    }

    public static void EndProgram()
    {

      foreach (RepeatCounter i in RepeatCounter.GetInstances())
      {
        Console.WriteLine($"sentence, {i.Sentence}, contained, {i.Word}, count, {i.GetCount()}");
      }
      Console.WriteLine("Print Summary to .txt file? [Y]/[N]");
      string resp = Console.ReadLine().ToLower();

      if (resp.Contains("y"))
      {
        List<string> summ = new List<string> { };
        foreach (RepeatCounter i in RepeatCounter.GetInstances())
        {
          summ.Add($"sentence, {i.Sentence}, contained, {i.Word}, count, {i.GetCount()}");
        }
        PrintSummary(summ);
      }
      else
      {
        Console.ReadLine();
        Environment.Exit(0);
      }

    }

    public static void PrintSummary(List<string> summary)
    {
      string startupPath = Environment.CurrentDirectory;
      System.IO.File.WriteAllLines(startupPath + "/WordCountSummary.txt", summary);
      Console.ReadLine();
      Environment.Exit(0);
    }

    public static bool RunProgramLoop()
    {
      bool view = false;
      string[] inputs = ReturnValidStrings();

      RepeatCounter newCounter = new RepeatCounter(inputs[0], inputs[1]);
      string t = "";

      if (newCounter.GetCount() > 1)
      {
        t = "times";
      }
      else
      {
        t = "time";
      }
      Console.WriteLine($"The word '{newCounter.Word}' appears {newCounter.GetCount()} {t} in the sentence '{newCounter.Sentence}' ");


      if (RepeatCounter.GetInstances().Count > 0)
      {
        Console.WriteLine("If you want to try again, press Enter.");
        Console.WriteLine("If you want to [V]iew your previous entries, press V and enter.");
        string resp = Console.ReadLine().ToLower();
        if (resp == "v")
        {
          view = true;
        }
        else
        {
          view = false;
        }
      }

      return view;
    }

    public static string[] ReturnValidStrings()
    {
      bool sentBool = false;
      bool wordBool = false;
      string sentResp = "";
      string wordResp = "";
      string[] validInputs = { "", "" };
      while (sentBool == false)
      {
        Console.WriteLine("Enter a sentence: ");
        sentResp = Console.ReadLine();
        sentBool = RepeatCounter.CheckIfValid(sentResp);
        if (!sentBool)
        {
          Console.WriteLine("Please enter a valid sentence!");
        }
      }
      while (wordBool == false)
      {
        Console.WriteLine("Enter a word: ");
        wordResp = Console.ReadLine();
        wordBool = RepeatCounter.CheckIfValid(wordResp);
        if (!wordBool)
        {
          Console.WriteLine("Please enter a valid word!");
        }
      }
      validInputs[0] = sentResp;
      validInputs[1] = wordResp;
      return validInputs;

    }
  }
}