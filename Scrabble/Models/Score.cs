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
      List<char> onePoint = new List<char>{'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'}; 
      List<char> twoPoints = new List<char>{'d', 'g'};
      List<char> threePoints = new List<char>{'b', 'c', 'm', 'p'};
      List<char> fourPoints = new List<char>{'f', 'h', 'v', 'w', 'y'};
      List<char> fivePoints = new List<char>{'k'};
      List<char> eightPoints = new List<char>{'j', 'x'};
      List<char> tenPoints = new List<char>{'q', 'z'};

      foreach(char letter in word) 
      {
        if (onePoint.Contains(letter)) result += 1;
        else if (twoPoints.Contains(letter)) result += 2;
        else if(threePoints.Contains(letter)) result += 3;
        else if(fourPoints.Contains(letter)) result += 4;
        else if(fivePoints.Contains(letter)) result += 5;
        else if(eightPoints.Contains(letter)) result += 8;
        else result += 10;
      }
      return result;

      /*
      foreach(char letter in word) //Contains
      {
        Console.WriteLine($"<{letter}>"); 
        if(letter == 'a' || letter ==  'e'|| letter ==  'i'|| letter ==  'o'|| letter ==  'u'|| letter ==  'l'|| letter ==  'n'|| letter ==  'r'|| letter ==  's'|| letter ==  't') 
        {
          result += 1;
        }
        else if(letter == 'd' || letter == 'g')
        {
          result += 2;
        }
        else if(letter == 'b' || letter == 'c' || letter == 'm' || letter == 'p')
        {
          result += 3;
        }
        else if(letter == 'f' || letter == 'h' || letter == 'v' || letter == 'w' || letter == 'y')
        {
          result += 4;
        }
        else if(letter == 'k')
        {
          result += 5;
        }
        else if(letter == 'j' || letter == 'x')
        {
          result += 8;
        }
        else if(letter == 'q'|| letter == 'z')
        {
          result += 10;
        }
      
      }
      return result;
      */
      
    }

    // properties, methods, etc. will go here.

  }
}