using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Score
  {
    public static int GetScore (string word)
    {
      //string[] chars = word.Split('');
      int result = 0; 
      foreach(char letter in word)
      {
        Console.WriteLine($"<{letter}>"); 
        if(letter == 'a' || letter ==  'e'|| letter ==  'i'|| letter ==  'o'|| letter ==  'u'|| letter ==  'l'|| letter ==  'n'|| letter ==  'r'|| letter ==  's'|| letter ==  't') 
        {
          result += 1;
          Console.WriteLine(result);
        }
        else if(letter == 'd' || letter == 'g')
        {
          result += 2;
          Console.WriteLine(result);
        }
        else if(letter == 'b' || letter == 'c' || letter == 'm' || letter == 'p')
        {
          result += 3;
          Console.WriteLine(result);
        }
        else if(letter == 'f' || letter == 'h' || letter == 'v' || letter == 'w' || letter == 'y')
        {
          result += 4;
          Console.WriteLine(result);
        }
        else if(letter == 'k')
        {
          result += 5;
          Console.WriteLine(result);
        }
        else if(letter == 'j' || letter == 'x')
        {
          result += 8;
          Console.WriteLine(result);
        }
        else if(letter == 'q'|| letter == 'z')
        {
          result += 10;
          Console.WriteLine(result);
        }
      
      }
      return result;
      
      
    }

    // properties, methods, etc. will go here.

  }
}