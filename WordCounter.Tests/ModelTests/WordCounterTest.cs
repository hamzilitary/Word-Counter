using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounters.Models;

namespace WordCounters.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void GetText_ConstructorTest()
    {
      //Arrange
      WordCounter wordCounter = new WordCounter("Crazy", "Cool");

      //Act
      string result = wordCounter.GetText();

      //Assert
      Assert.AreEqual("Crazy", result);
    }

    [TestMethod]
    public void GetFind_ConstructorTest()
    {
      //Arrange
      WordCounter wordCounter = new WordCounter("Crazy", "Cool");

      //Act
      string result = wordCounter.GetFind();

      //Assert
      Assert.AreEqual("Cool", result);
    }


    [TestMethod]
    public void GetIndex_ReturnIndex()
    {
      //Arrange
      WordCounter wordCounter = new WordCounter("Crazy", "Cool");

      //Act
      int result = wordCounter.GetIndex(0);

      //Assert
      Assert.AreEqual(-1, result);
    }

  }
}
