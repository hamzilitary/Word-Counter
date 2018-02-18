using Microsoft.AspNetCore.Mvc;
using WordCounters.Models;


namespace WordCounters.Controllers


{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/Results")]
    public ActionResult Results()//WordCounter newFind)
    {
      //var otherResult = new WordCount() { Text ="" };
      //otherResult.Text = "";
      string text = Request.Form["text"];
      string find = Request.Form["find"];
      string replace = Request.Form["replace"];
      WordCounter newFind = new WordCounter(text, find, replace);
      newFind.ReplaceAll();
      return View(newFind);
    }
  }
}
