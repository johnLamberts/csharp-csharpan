using System.Numerics;
using dsa_csharp.Algorithms.Numeric;
using Xunit;

public static class FactorialTests
{
      [Theory]
      [InlineData(0, "1")]
      [InlineData(1, "1")]
      [InlineData(4, "24")]
      [InlineData(10, "3628800")]
      [InlineData(18, "6402373705728000")]
      public static void GetsFactorial(int input, string expected)
      {
      
        //When        
        BigInteger expectedBigInt = BigInteger.Parse(expected);

        // Act
        var result = Factorial.Calculate(input);

        // Assert
        Assert.Equal(expectedBigInt, result);
      }
}