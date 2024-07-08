using dsa_csharp.Algorithms.String;
using Xunit;

public static class PalindromeTests
{
      [Theory]
      [InlineData("A santa at Nasa")]
      [InlineData("Anna")]
      public static void TextIsPalindrome_TrueExpected(string text)
      {
            var IsStringPalindrome = Palindrome.IsStringPalindrome(text);

            Assert.True(IsStringPalindrome);
      }


      [Theory]
      [InlineData("Hello")]
      [InlineData("Once upon a time")]
      public static void TextIsPalindrome_FalseExpected(string text)
      {
            Console.WriteLine(text);      
            var IsStringPalindrome = Palindrome.IsStringPalindrome(text);
            Assert.False(IsStringPalindrome);
      }

}