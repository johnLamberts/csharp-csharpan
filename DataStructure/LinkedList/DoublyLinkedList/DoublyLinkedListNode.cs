
namespace dsa_csharp.DataStructure.LinkedList;

class DoublyLinkedListNode<T> 
{

      public DoublyLinkedListNode(T data) => Data = data;

      public T Data { get; }

      public DoublyLinkedListNode<T>? Next { get; set; }

      public DoublyLinkedListNode<T>? Previous {get; set; } 
}