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

    [TestMethod]
    public void GetArray_ReturnsStringAsArray_Array()
    {
      string word1 = "bread";
      Game newGame = new Game(word1);
      char[] FirstArray = {'b', 'r', 'e', 'a', 'd'};
      char[] result = newGame.CheckWord();
      CollectionAssert.AreEqual(FirstArray, result);
    }

    [TestMethod]
    public void SortArray_ReturnSortedArray_Array()
    {
      string word1 = "bread";
      Game newGame = new Game(word1);
      char[] charArray = {'a', 'b', 'd', 'e', 'r'};
      char[] result = newGame.SortWord();
      Assert.AreEqual(charArray, result);
    }
  }
}