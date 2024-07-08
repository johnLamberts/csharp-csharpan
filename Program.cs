using Algorithms.String;
using dsa_csharp.Algorithms.Numeric;
using dsa_csharp.Algorithms.Search;
using dsa_csharp.Algorithms.String;
using dsa_csharp.DataStructure.Queue;
using dsa_csharp.DataStructure.SinglyLinkedList;
using dsa_csharp.DataStructure.Stack;

namespace dsa_csharp;

class Program
{
    static void Main(string[] args)
    {


    // Basic Usage:
    // Binary Search   
    //
    //    var test = new[]
    //    {
    //     2, 3, 5, 7, 11, 13, 17, 19,
    //             23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79
    //    };
    //
    //    Console.WriteLine(BinarySearch.Search(test, 101));



    // Basic Usage:
    // Boyer-Moore Algorithm
    //
    // Definition:
    //
    // This algorithm is one of the popular optimal algorithms
    // which is used to find the majority element among the given elements
    // that have more than N/2 occurences.
    //
    // Basic Usage:
    //
    // var elementCount = 1000;
    // var rnd = new Random();
    // var randomNums = new List<int>();
    // while (randomNums.Count < elementCount / 2) randomNums.Add(rnd.Next(0, elementCount));
    // var majorityElement = rnd.Next(0, elementCount);
    // randomNums.AddRange(Enumerable.Repeat(majorityElement, elementCount / 2 + 1));
    // randomNums = randomNums.OrderBy(x => rnd.Next()).ToList();
    // var expected = majorityElement;
    // var actual = BoyerMoore<int>.FindMajority(randomNums);
    // Console.WriteLine($"Assertion Equals: Actual: {actual} ---- Expected: {expected}");


    // var linkedList = new SinglyLinkedList<char>();

    // linkedList.AddFirst('H');
    // linkedList.AddFirst('E');
    // linkedList.AddFirst('L');
    // linkedList.AddFirst('L');
    // linkedList.AddFirst('O');

    //     foreach (var list in linkedList.GetListData()) 
    //     {
    //         Console.WriteLine(list);
    //     }

    var isPalindrome = Permutation.GetEveryUniquePermutation("abcd");

    foreach (var letrs in isPalindrome) Console.WriteLine(letrs);
    }
}
