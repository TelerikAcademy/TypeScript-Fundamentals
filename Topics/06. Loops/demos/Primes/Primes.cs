using System;

class Primes
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var m = int.Parse(Console.ReadLine());

        for (int i = n; i <= m; i++)
        {
            var isPrime = true;

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }

                
            }

            if (isPrime)
            {
                Console.WriteLine("{0} is prime", i);
            }
        }
    }
}
