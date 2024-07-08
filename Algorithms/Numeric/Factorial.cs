using System.Numerics;

namespace dsa_csharp.Algorithms.Numeric;

public static class Factorial
{
      public static BigInteger Calculate(int inputNum)
      {
            BigInteger num = new BigInteger(inputNum);

            if(BigInteger.Compare(num, BigInteger.Zero) < 0) 
                  throw new ArgumentException("Only for num >= 0");

            BigInteger result = BigInteger.One;

            for(BigInteger i = BigInteger.One; BigInteger.Compare(i, num) <= 0; i = BigInteger.Add(i, BigInteger.One)) 
                  result = BigInteger.Multiply(result, i);

            return result;
      }
}