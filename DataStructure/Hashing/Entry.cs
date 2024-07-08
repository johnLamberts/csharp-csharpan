namespace dsa_csharp.DataStructure.Hashing;




/// <summary>
///   Entry in the Hash Table
/// </summary> 
/// <typeparam name="TKey">Type of the key.</typeparam>
/// <typeparam name="TValue">Type of the value.</typeparam>
/// <remarks>
///   This class is used to store the key-value pairs in the Hash Table.
/// </remarks>
public class Entry<TKey, TValue>
{
      public TKey? Key { get; set; }
      public TValue? Value { get; set; }

      public Entry(TKey key, TValue value) 
      {
            Key = key;
            Value = value;
      }
}
