using System;
namespace BitsToBits
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = int.Parse(Console.ReadLine());

      int maxZeroCount = 0;
      int currZeroCount = 0;

      int maxOneCount = 0;
      int currOneCount = 0;

      int lastBit = 5;

      for (int i = 0; i < n; i++)
      {
        int num = int.Parse(Console.ReadLine());

        for (int j = 29; j >= 0; j--)
        {
          int bit = ((1 << j) & num) >> j;

          if (bit == 1)
          {
            if (lastBit == 1)
            {
              currOneCount++;
              maxOneCount = Math.Max(maxOneCount, currOneCount);
            }
            else
            {
              currZeroCount = 0;
              currOneCount = 1;
            }
          }
          else // bit == 0
          {
            if (lastBit == 0)
            {
              currZeroCount++;
              maxZeroCount = Math.Max(maxZeroCount, currZeroCount);
            }
            else
            {
              currOneCount = 0;
              currZeroCount = 1;
            }
          }

          lastBit = bit;
        }
      }

      Console.WriteLine(maxZeroCount);
      Console.WriteLine(maxOneCount);
    }
  }
}
