using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System;
using System.Collections.Generic;

namespace Anagram.Tests

{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("bread");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GetResponse_ReturnsWordAsString_String()
    {
      string word1 = "bread";
      Game newGame = new Game(word1);
      string result = newGame.FirstWord;
      Assert.AreEqual(word1, result);
    }
  }
}