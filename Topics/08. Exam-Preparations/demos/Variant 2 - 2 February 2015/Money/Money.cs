namespace FundamentalsExam2016
{
    using System;

    public class Money
    {
        public static void Main()
        {
            // N * S / 400 * P

            int N = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
            decimal P = decimal.Parse(Console.ReadLine());

            const decimal realmPrice = 400.0M;

            decimal result = N * S / realmPrice * P;

            Console.WriteLine("{0:F3}", result);
        }
    }
}
