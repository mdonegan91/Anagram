using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests

{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }
  }
}