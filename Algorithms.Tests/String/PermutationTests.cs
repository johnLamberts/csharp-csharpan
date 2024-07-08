using dsa_csharp.Algorithms.String;
using Xunit;

public static class PermutationTests
{
      [Theory]
      // [InlineData("A")]
      [InlineData("abcd")]
      // [InlineData("aabcd")]
      // [InlineData("aabbbcd")]
      // [InlineData("aabbccccd")]
      public static void Test_GetEveryUniquePermutation(string word)
      {
            var permutations = Permutation.GetEveryUniquePermutation(word);

        
            // We need to make sure that
            // 1. We have the right number of permutations
            // 2. Every string in permutations List is a permutation of word
            // 3. There are no repetitions

            // Start 1.
            // The number of unique permutations is
            // n!/(A1! * A2! * ... An!)
            // where n is the length of word and Ai is the number of occurrences if ith char in the string
            var charOccurence = new Dictionary<char, int>();
            foreach (var c in word) 
            {
                  if(charOccurence.ContainsKey(c)) 
                        charOccurence[c] += 1;
                  else
                        charOccurence[c] = 1;
            }

            
      }
}