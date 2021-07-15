using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void GetScore_GetsScoreFromCat_Returns5 ()
    {
      Assert.AreEqual(Score.GetScore("cat"), 5);
    }
    // f = 4, l = 1, a = 1, m = 3, i = 1, n = 1, g = 2, o = 1
    [TestMethod]
    public void GetScore_GetsScoreFromFlamingo_Returns14 ()
    {
      Assert.AreEqual(Score.GetScore("flamingo"), 14);
    }
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
    // // Test methods will go here.

  }
}