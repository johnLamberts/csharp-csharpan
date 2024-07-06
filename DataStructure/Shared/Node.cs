
      public class Node<T>
      {
            #region Members
            public T Value;
            public Node<T>? Next;
            public Node<T>? Previous;
            #endregion

            #region constructor
            // public Node(T value)
            // {
            //       Value = value;
            //       Next = null;
            //       Previous = null;
            // }

            public Node()
            {
                  Value = default(T)!;
                  Next = null;
                  Previous = null;
            }
            #endregion

      }