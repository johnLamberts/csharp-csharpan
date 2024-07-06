namespace dsa_csharp.DataStructure.Stack
{
      public class MyStack<T> 
      {
            #region Members
            private Node<T>? Head;
            private Node<T>? Tail;
            private int Counter;
            #endregion

            #region Constructor
            public MyStack()
            {
                  this.Head = null;
                  this.Tail = null;
                  this.Counter = 0;
            }
            #endregion

            #region Public Methods

            /// <summary>
            /// Adds a new value to the end of the list.
            /// </summary>
            /// <param name="newValue">The value to be added to the list.</param>
            public void Push(T newValue)
            {
                  if(this.Head == null) 
                  {
                        this.Head = new Node<T>();
                        this.Tail = this.Head;
                  }
                  else 
                  {
                        this.Head.Next = new Node<T>();
                        this.Head.Next.Previous = this.Head;
                        this.Head = this.Head.Next;
                  }

                  this.Head.Value = newValue;
                  this.Counter++;
            }

            /// <summary>
            /// Returns the value at the top of the stack without removing it.
            /// </summary>
            /// <returns>The value at the top of the stack.</returns>
            public T Top()
            {
                  if(this.Head != null)
                  {
                        return this.Head.Value;
                  }

                  throw new InvalidOperationException("The stack is empty.");
            }


            public T Pop()
            {
                  if(this.Head == null) return default(T)!;


                  T valueToReturn = this.Head.Value;

                  if(this.Head.Previous == null) 
                  {
                        this.Head = null;
                        this.Tail = null;
                  }
                  else
                  {
                        this.Head = this.Head.Previous;
                        this.Head.Next = null;
                  }

                  this.Counter--;
                  
                  return valueToReturn;
            }

            /// <summary>
            /// Prints all the items in the stack.
            /// </summary>
            public void PrintAll()
            {
                  var current = this.Tail;
                  
                  while(current != null)
                  {
                        Console.WriteLine(current.Value);
                        current = current.Next;
                  }
            }
            

            public int Count()
            {
                  return this.Counter;
            }

          
            #endregion
      }
}