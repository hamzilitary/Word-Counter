using System.Collections.Generic;
using System;

namespace WordCounters.Models
{
  public class WordCounter
  {
    private string _text;
    private string _find;
    private string _result;

    public WordCounter(string text, string find)
    {
      _text = text;
      _find = find;
    }

    public string GetText()
    {
      return _text;
    }
    public string GetFind()
    {
      return _find;
    }
    public string GetResult()
    {
      return _result;
    }
    public int GetIndex(int start)
    {
      string text = _text.Substring(start, _text.Length - start).ToLower();
      return text.IndexOf(_find.ToLower()) + start;
    }

  }

}
