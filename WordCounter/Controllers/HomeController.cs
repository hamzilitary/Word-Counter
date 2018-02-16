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

    [HttpPost("/")]
    public ActionResult Result()
    {
      string text = Request.Form["text"];
      string find = Request.Form["find"];
      string replace = Request.Form["replace"];
      WordCounter newFind = new WordCounter(text, find, replace);
      newFind.ReplaceAll();
      return View("Result", newFind);
    }
  }
}
