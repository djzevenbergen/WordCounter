namespace WordCounter.Models
{
  public class RepeatCounter
  {

    public string Sentence { get; set; }
    public string Word { get; set; }

    private int _count;

    public int GetCount()
    {
      return _count;
    }

    public RepeatCounter(string sent, string word)
    {
      Sentence = sent;
      Word = word;

      _count = CountRepeats(sent, word);
    }

    public int CountRepeats(string sent, string word)
    {
      string[] stringArray = sent.ToLower().Split(" ");
      int count = 0;
      foreach (string w in stringArray)
      {
        if (w.Contains(word.ToLower()))
        {
          count += 1;
        }
      }

      return count;
    }

  }
}