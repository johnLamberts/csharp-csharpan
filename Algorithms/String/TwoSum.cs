namespace Algorithms.String
{
      public class TwoSum
      {


            /// <summary>
            /// Finds two indices in the array such that their values add up to the target.
            /// </summary>
            /// <param name="arr">The input array of integers.</param>
            /// <param name="target">The target sum to find in the array.</param>
            /// <returns>An array containing the two indices if found; otherwise, an empty array.</returns>
            public int[] TwoSumBruteForce(int[] arr, int target)
            {     
                  for(int i = 0; i < arr.Length; i++) 
                  {
                        for(int j = i + 1; j < arr.Length; j++)
                        {
                              if(arr[i] + arr[j] == target) 
                              {     
                                    Console.WriteLine($"[{i}, {j}]");
                                    return [i, j];
                              }
                        }
                  }

                  return [];
            }
      }
}