using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("Hey there, I can take a sentence and a word, and I can count how many times that word appears in that sentence");
      bool sentBool = false;
      bool wordBool = false;
      string sentResp = "";
      string wordResp = "";
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

      RepeatCounter newCounter = new RepeatCounter(sentResp, wordResp);

      Console.WriteLine($"The word '{newCounter.Word}' appears {newCounter.GetCount()} times in the sentence '{newCounter.Sentence}' ");




    }
  }
}