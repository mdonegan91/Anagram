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

    private string _secondWord;
    public string SecondWord
    {
      get { return _secondWord; }
      set { _secondWord = value; }
    }

    private string _thirdWord;
    public string ThirdWord
    {
      get { return _thirdWord; }
      set { _thirdWord = value; }
    }

    // private string _fourthWord;
    // public string FourthWord
    // {
    //   get { return _fourthWord; }
    //   set { _fourthWord = value; }
    // }

    public Game(string word1, string word2, string word3)
    {
      _firstWord = word1;
      _secondWord = word2;
      _thirdWord = word3;
      // _fourthWord = word4;
    }

    public string CheckWord(string word1, string word2, string word3)
    {
      char[] charArray1 = _firstWord.ToCharArray();
      Array.Sort(charArray1);
      char[] charArray2 = _secondWord.ToCharArray();
      Array.Sort(charArray2);
      char[] charArray3 = _thirdWord.ToCharArray();
      Array.Sort(charArray3);

      string newWord1 = String.Join("", charArray1);
      string newWord2 = String.Join("", charArray2);
      string newWord3= String.Join("", charArray3);

      if ((newWord1 != newWord2) || (newWord1 != newWord3))
      {
        return "no anagrams found";
      }
      else if ((newWord1 == newWord2) && (newWord1 == newWord3))
      {
        return "all words are anagrams";
      }
      else if ((newWord1 == newWord2) || (newWord1 == newWord3))
      {
        return "one anagram found";
      }
      // (newWord1 == newWord2)
      // {
      //   return "true";
      // } 
      // else
      // {
      //   return "false";
      // }
    }

  }
}
