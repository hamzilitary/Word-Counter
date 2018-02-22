using System.Collections.Generic;
using System;

namespace WordCounters.Models
{
  public class WordCounter
  {
    //public string Text { get; set; }

//    public string Result {
//      get {
//        return GetResult();
//      }
//    }

    private string _text;
    private string _find;


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


    public int GetIndex(int start)
    {
      //return _text.ToLower().IndexOf(_find.ToLower());
      string text = _text.Substring(start, _text.Length - start).ToLower();
      return text.IndexOf(_find.ToLower()) + start;
    }

    public int CountWordInstances() {
      //return _text.ToLower().Split(new [] { _find.ToLower() }, StringSplitOptions.None).Length - 1;
      var words = _text.ToLower().Split(" ,.!?".ToCharArray());
      int result = 0;
      string lowerCaseFind = _find.ToLower();
      for(int i = 0; i < words.Length; i++)
      {
        if (words[i] == _find)
        {
          result++;
        }

      }
      return result;
    }



  }
}
