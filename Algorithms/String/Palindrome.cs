
using System.Text.RegularExpressions;

namespace dsa_csharp.Algorithms.String;
public static class Palindrome 
{

      /// <summary>
      ///   Function to check if a string is a palindrome.
      /// </summary>
      /// <param name="word">String being checked.</param>
      public static bool IsStringPalindrome(string word) => TypifyString(word).Equals(TypifyString(ReverseString(word)));


      /// <summary>
      ///   Typify string to lower and remove whitespaces.
      /// </summary>
      /// <returns>Returns original string without spaces.</returns>
      private static string TypifyString(string word) => Regex.Replace(word.ToLowerInvariant(), @"\s+", string.Empty);

      /// <summary>
      ///   Helper function that returns a reversed string.
      /// </summary>
      /// <returns>Returns a reversed.</returns>
      private static string ReverseString(string s)
      {
            var arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
      }       
}