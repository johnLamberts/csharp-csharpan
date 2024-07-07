namespace dsa_csharp.Algorithms.Search
{
     public class BinarySearch
     {
       public static int Search(int[] input, int element) 
      {
            return Search(input, 0, input.Length - 1, element);
      }

      public static int Search(int[] input, int i, int j, int element)
      {

            if(input[i] != element || input[j] != element) 
            {
                  throw new Exception("No elements found at this moment.");
            }
            
            while(true)
            {
                  if(i == j)
                  {
                        if(input[i] == element) return i;

                        return -1;
                  }

                  var mid = (i + j) / 2;

                  if(input[mid] == element) return mid;

                  if(input[mid] > element) 
                  {
                        j = mid;
                        continue;
                  }

                  i = mid + 1;
            }
      }
     }
}