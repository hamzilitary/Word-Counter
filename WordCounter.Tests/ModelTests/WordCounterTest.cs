using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounters;
using WordCounters.Models;
using System.Collections.Generic;

namespace WordCounters.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void GetText_ConstructorTest()
    {
      //Arrange
      WordCounter wordCounter = new WordCounter("Crazy", "Cool", "Nice");

      //Act
      string result = wordCounter.GetText();

      //Assert
      Assert.AreEqual("Crazy", result);
    }
  }
}
