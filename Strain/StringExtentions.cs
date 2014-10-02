using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strain
{
  static class StringExtentions
  {
    public static string Repeat(this char chatToRepeat, int repeat)
    {
      return new string(chatToRepeat, repeat);
    }

    public static string Repeat(this string stringToRepeat, int repeat)
    {
      var builder = new StringBuilder(repeat);
      for (int i = 0; i < repeat; i++)
      {
        builder.Append(stringToRepeat);
      }
      return builder.ToString();
    }
    
    public static int WordCount(this String str)
    {
      return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
  }
}
