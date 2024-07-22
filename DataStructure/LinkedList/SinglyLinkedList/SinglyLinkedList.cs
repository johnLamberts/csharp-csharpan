namespace dsa_csharp.DataStructure.LinkedList;

public class SinglyLinkedList<T> 
{
      private SinglyLinkedListNode<T>? Head { get; set; }

      /// <summary>
      ///   Adds new node to the "start" of the listm
      /// ----
      ///   Time Complexity: 0(1)
      ///   Space Complexity: 0(1)
      /// ----
      /// <param name="data">Contents of newly added node.</param>
      /// <returns>Added list node.</returns>
      public SinglyLinkedListNode<T> AddFirst(T data)
      {
            var newListElement = new SinglyLinkedListNode<T>(data) { Next = Head };

            Head = newListElement;
            return newListElement;
      }


      /// <summary>
      ///   Adds new node to the "end" of the listm
      /// ----
      ///   Time Complexity: 0(n)
      ///   Space Complexity: 0(1)
      /// ----
      /// <param name="data">Contents of newly added node.</param>
      /// <returns>Added list node.</returns>
      public SinglyLinkedListNode<T> AddLast(T data)
      {
            var newListElement = new SinglyLinkedListNode<T>(data);

            // If "head" is null, the added element is the first, hence 
            // it is the "head".

            if(Head is null)
            {
                  Head = newListElement;
                  return newListElement;
            }

            // Temp ListElemenet to avoid overwriting the original.
            var tempElement = Head;

            // iterates through all elements.
            while(tempElement.Next is not null)
            {
                  tempElement = tempElement.Next;
            }

            tempElement.Next = newListElement;

            return newListElement;
      }

      /// <summary>
      ///   Returns element at index <paramref name="index" /> in the list.
      /// </summary>
      /// <param name="index">Index of an element to be returned.</param>
      /// <returns>Element at index <paramref name="index" />.</returns>
      public T GetElementByIndex(int index)
      {
            if(index < 0) 
                  ArgumentOutOfRangeException.ThrowIfNegative(index);

            var tempElement = Head;

            for(var i = 0; tempElement is not null && i < index; i++) 
            {
                  tempElement = tempElement.Next;
            }

            if(tempElement is null)
            {
                  throw new ArgumentOutOfRangeException(nameof(index));
            }

            return tempElement.Data;
      }

      public int Length()
      {
            // checks if there is a head
            if(Head is null) return 0;

            var tempElement = Head;
            var length = 1;

            while (tempElement.Next is not null) {
                  tempElement = tempElement.Next;
                  length++;
            }

            return length;
      }

      public IEnumerable<T> GetListData()
      {
            // temp ListElement to avoid overwriting the original.
            var tempElement = Head;

            while (tempElement is not null)
            {
                  yield return tempElement.Data;
                  tempElement = tempElement.Next;
            }
      }


      

}