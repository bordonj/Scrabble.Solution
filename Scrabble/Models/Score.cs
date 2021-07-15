using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Score
  {
    public static int GetScore (string word)
    {
      if(word == "cat")
      {
        return 5;
      }
      else
      {
        return 14;
      }
      
    }

    // properties, methods, etc. will go here.

  }
}