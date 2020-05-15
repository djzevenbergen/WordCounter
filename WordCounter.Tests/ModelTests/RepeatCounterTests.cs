using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]

  public class WordCounterTests
  {
    [TestMethod]

    public void RepeatCounter_IsInitialized_RepeatCounter()
    {
      string sent = "There is a rat over there";
      string word = "there";
      RepeatCounter testCounter = new RepeatCounter(sent, word);

      Assert.AreEqual(typeof(RepeatCounter), testCounter.GetType());
    }

    [TestMethod]

    public void RepeatCounter_PropertiesAreSet_StringStringInt()
    {
      string sent = "There is a rat over there";
      string word = "there";
      RepeatCounter testCounter = new RepeatCounter(sent, word);

      Assert.AreEqual(sent, testCounter.Sentence);
      Assert.AreEqual(word, testCounter.Word);
      Assert.AreEqual(2, testCounter.GetCount());
    }


  }
}