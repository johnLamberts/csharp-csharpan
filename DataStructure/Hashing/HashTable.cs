namespace dsa_csharp.DataStructure.Hashing;

/// <summary>
///   Hash Table Implementation
/// </summary>
/// <typeparam name="TKey"></typeparam>
/// <typeparam name="TValue"></typeparam>
public class HashTable<TKey, TValue>
{
      private const int DefaultCapacity = 16;
      private const float DefaultLoadFactor = 0.75f;

      private readonly float loadFactor;
      private int capacity;
      private int size;
      private int threshold;
      private int version;

      private Entry<TKey, TValue>?[] entries;

      /// <summary>
      ///   Gets the number of elements in the Hash Table.
      /// </summary>
      public int Count => size;

      /// <summary>
      ///   Gets the capacity of elements in the Hash Table.
      /// </summary>
      public int Capacity => capacity;


      /// <summary>
      ///   Gets the loads factor of the Hash Table
      /// </summary>
      /// <returns></returns>
      public float LoadFactor() => loadFactor;

      /// <summary>
      /// Gets the values in the Hash Table.
      /// </summary>
      public IEnumerable<TValue> Values => entries.Where(e => e is not null).Select(e => e!.Value!);


      public HashTable(int capacity = DefaultCapacity, float loadFactor = DefaultLoadFactor)
      {
            if(capacity <= 0) 
                  throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than 0");
            
          
           if(loadFactor <= 0) 
                  throw new ArgumentOutOfRangeException(nameof(loadFactor), "Load Factor must be greater than 0");
            
            if(loadFactor > 1) 
                  throw new ArgumentOutOfRangeException(nameof(loadFactor), "Load Factor must be less than or equal to 1");
            
            // this.capacity = 
      }

}     