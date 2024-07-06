using Algorithms.String;
using dsa_csharp.DataStructure.Stack;

namespace dsa_csharp;

class Program
{
    static void Main(string[] args)
    {
       int[] arr = { 2, 7, 11, 15 };
       int targets = 9;

       var twoSum = new TwoSum();

        twoSum.TwoSumBruteForce([1, 5, 8, -1, 6, -9, 3], 7);
    }
}
