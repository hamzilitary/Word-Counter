using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
  }
}
