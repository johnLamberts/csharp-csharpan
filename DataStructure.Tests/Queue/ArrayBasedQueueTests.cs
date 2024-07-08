using Xunit;
using dsa_csharp.DataStructure.Queue;
using System;
using System.Text;

namespace dsa_csharp.DataStructure.Tests.Queue;

public class ArrayBasedQueueTest 
{
      [Fact]
      public static void DequeueWorks()
      {
            // Arrange
            var q = new ArrayBasedQueue<char>(3);

            q.Enqueue('A');
            q.Enqueue('B');
            q.Enqueue('C');
            var result = new StringBuilder();

            // Act
            for (var i = 0; i < 3; i++)
                  result.Append(q.Dequeue());
            
            // Assert
            Assert.Equal("ABC", result.ToString());
            Assert.True(q.IsEmpty(), "Queue is empty");
            Assert.False(q.IsFull(), "Queue is full");
      }

      [Fact]
      public static void PeekWorksCorrectly()
      {
            // Arrange 
            var q = new ArrayBasedQueue<int>(2);
            q.Enqueue(10);
            q.Enqueue(5);
            
            var peeked = 0;

            // Act
            for (var i = 0; i < 3; i++)
            {
                  peeked = q.Peek();
            }

            Console.WriteLine(peeked);
            Assert.Equal("10", peeked.ToString());

            // Assert
      }

}

