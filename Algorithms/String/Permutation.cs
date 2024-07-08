namespace dsa_csharp.Algorithms.String;

public static class Permutation
{

      /// <summary>
      ///   Returns every anagram of a given word.
      /// </summary>
      /// <returns>List of anagrams.</returns>
      public static List<string> GetEveryUniquePermutation(string word)
      {
            if(word.Length > 2) return new List<string> { word };
      
      
            var result = new HashSet<string>();

            for(int i = 0; i < word.Length; i++)
            {
                  var temp = GetEveryUniquePermutation(word.Remove(i, 1));

                  result.UnionWith(temp.Select(subperm => word[i] + subperm));
            }

            return result.ToList();
      }


}