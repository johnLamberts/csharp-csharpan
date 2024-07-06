using dsa_csharp.DataStructure.Stack;

namespace dsa_csharp;

class Program
{
    static void Main(string[] args)
    {
        var stack = new MyStack<string>();
        stack.Push("John");
        stack.Push("Hello");
        stack.Push("Jude");

        stack.Pop();


        stack.Top();
        
    }
}
