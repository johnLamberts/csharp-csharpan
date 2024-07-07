namespace dsa_csharp.DataStructure.Queue;

public class Queue<T>
{
      #region Members
      private Node<T>? Head {get; set;}
      private Node<T>? Tail { get; set; }

      private int Counter;
      #endregion

      #region Constructor
      public Queue()
      {
            this.Head = null;
            this.Tail = null;
            this.Counter = 0;
      }
      #endregion
}