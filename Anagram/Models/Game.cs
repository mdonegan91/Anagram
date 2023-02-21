using System;
using System.Collections.Generic;

namespace Anagram.Models

{
  public class Game
  {
    private string _firstWord;
    public string FirstWord
    {
      get { return _firstWord; }
      set { _firstWord = value; }
    }

    public Game(string word1)
    {
      _firstWord = word1;
    }

    public char[] CheckWord()
    {
      char[] charArray = _firstWord.ToCharArray();
      return charArray;
    }
    
  }
}