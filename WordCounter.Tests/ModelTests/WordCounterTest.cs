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

    [TestMethod]
    public void DoesNotMatchPartialWordTest()
    {
      //Arrange
      WordCounter wordCounter = new WordCounter("Hello how are you?", "ow");

      //Act
      int result = wordCounter.CountWordInstances();

      //Assert
      Assert.AreEqual(0, result);

    }
    [TestMethod]
    public void DoesMatchFullWordTest()
    {
      //Arrange
      WordCounter wordCounter = new WordCounter("Hello how are you? How did I pass this?", "how");

      //Act
      int result = wordCounter.CountWordInstances();

      //Assert
      Assert.AreEqual(2, result);

    }


  }
}
