using Algorithms.String;
using dsa_csharp.Algorithms.Search;
using dsa_csharp.DataStructure.Stack;

namespace dsa_csharp;

class Program
{
    static void Main(string[] args)
    {
       var test = new[]
       {
        2, 3, 5, 7, 11, 13, 17, 19,
                23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79
       };

       Console.WriteLine(BinarySearch.Search(test, 101));
    }
}
