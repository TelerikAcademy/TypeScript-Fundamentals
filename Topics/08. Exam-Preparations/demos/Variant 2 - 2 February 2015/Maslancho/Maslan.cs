namespace Maslancho
{
    using System;
    using System.Numerics;

    public class Maslan
    {
        public static void Main()
        {
            // keep track of transformations
            int transformationsCount = 0;

            // the input in some cases overflows ulong
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            // maslan does transformations while these two conditions are met
            while (transformationsCount < 10 && 9 < n)
            {
                BigInteger oddProduct = 1;

                // while maslan's number has any digits left
                while (n > 0)
                {
                    n /= 10;
                    string nString = n.ToString();
                    int oddSum = 0;

                    // take every odd digit, hence the starting from 1 and the update by 2
                    for (int i = 1; i < nString.Length; i += 2)
                    {
                        // convert char digit to it's corresponding int value
                        oddSum += nString[i] - '0';
                    }

                    // ignore 0 sums
                    if (oddSum != 0)
                    {
                        oddProduct *= oddSum;
                    }
                }

                // take the product of the sums and make it the new number
                n = oddProduct;
                // one more transformation has occurred
                transformationsCount++;
            }

            // if less than 10, print the count
            if (transformationsCount < 10)
            {
                Console.WriteLine(transformationsCount);
            }
            else if (transformationsCount > 10)
            {
                // some reality check ;>
                throw new Exception("Should not happen");
            }

            // print answer
            Console.WriteLine(n);
        }
    }
}
