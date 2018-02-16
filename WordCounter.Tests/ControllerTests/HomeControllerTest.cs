using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounters.Controllers;
using WordCounters.Models;

namespace WordCounters.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      ViewResult indexView = new HomeController().Index() as ViewResult;

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));

    }
  }
}
