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
    private string _replace;
    private string _result;
//    public WordCounter() {}

    public WordCounter(string text, string find, string replace)
    {
      _text = text;
      _find = find;
      _replace = "<span class = 'red'>" + replace + "</span>";

    }

    public string GetText()
    {
      return _text;
    }
    public string GetFind()
    {
      return _find;
    }
    public string GetReplace()
    {
      return _replace;
    }
    public string GetResult()
    {
      return _result;
    }
    public int GetIndex(int start)
    {
      //return _text.ToLower().IndexOf(_find.ToLower());
      string text = _text.Substring(start, _text.Length - start).ToLower();
      return text.IndexOf(_find.ToLower()) + start;
    }

    public int CountWordInstances() {
      return _text.ToLower().Split(new [] { _find.ToLower() }, StringSplitOptions.None).Length - 1;
    }

    public void ReplaceAll()
    {
      string newText = "";
      int lastIndex = 0;
      while (true)
      {
        int index = GetIndex(lastIndex);
        if(index < lastIndex)
        {
          break;
        }
        newText += _text.Substring(lastIndex, index - lastIndex) + _replace;
        lastIndex = index + _find.Length;
      }
      newText += _text.Substring(lastIndex, _text.Length - lastIndex);
      _result = newText;

    }

  }

}
