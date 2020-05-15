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

    [TestMethod]

    public void RepeatCounter_CalculatesZeroWhenNoMatch_Int()
    {
      string sent = "There is a rat over there";
      string word = "than";
      RepeatCounter testCounter = new RepeatCounter(sent, word);

      Assert.AreEqual(0, testCounter.GetCount());
    }

    [TestMethod]

    public void CheckIfValid_ChecksInputIsGreaterThanZero_False()
    {
      string test = "";
      bool response = RepeatCounter.CheckIfValid(test);

      Assert.AreEqual(false, response);
    }

    [TestMethod]

    public void CheckIfValid_ChecksInputIsNotJustSpaces_False()
    {
      string test = "         ";
      bool response = RepeatCounter.CheckIfValid(test);

      Assert.AreEqual(false, response);
    }

    [TestMethod]

    public void CheckIfValid_ChecksInputIsPopulatedString_True()
    {
      string test = "there is a thing";
      bool response = RepeatCounter.CheckIfValid(test);

      Assert.AreEqual(true, response);
    }



  }
}