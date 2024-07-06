namespace Algorithms.String
{
      public class TwoSum
      {


            //
            // Summary:
            //     Returns a value that indicates whether there is an object at the top of the System.Collections.Generic.Stack`1,
            //     and if one is present, copies it to the result parameter. The object is not removed
            //     from the System.Collections.Generic.Stack`1.
            //
            // Parameters:
            //   result:
            //     If present, the object at the top of the System.Collections.Generic.Stack`1;
            //     otherwise, the default value of T.
            //
            // Returns:
            //     true if there is an object at the top of the System.Collections.Generic.Stack`1;
            //     false if the System.Collections.Generic.Stack`1 is empty.

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