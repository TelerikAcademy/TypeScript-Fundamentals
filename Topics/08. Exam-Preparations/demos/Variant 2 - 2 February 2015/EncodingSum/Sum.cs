namespace EncodingSum
{
    using System;

    public class Sum
    {
        public static void Main()
        {
            // read input
            int M = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            // setup result
            int result = 0;

            // @ is always the last symbol, therefore we skip it - hence the iteration from 0 to text.Length - 1
            for (int i = 0; i < text.Length - 1; i++)
            {
                char symbol = text[i];

                if (char.IsDigit(symbol))
                {
                    // convert digit as char to digit as int
                    // can also be done with char.GetNumericValue(symbol);
                    result *= symbol - '0';
                }
                else if (char.IsLetter(symbol))
                {
                    // convert the character to lowercase, so we can handle all characters the same, independent of their case
                    // (char)(symbol | ' ');
                    char symbolToLower = char.ToLower(symbol);

                    // this is how we find the index of a letter in the latin alphabet and add it to result
                    result += symbolToLower - 'a';
                }
                else
                {
                    result %= M;
                }
            }

            // print the answer
            Console.WriteLine(result);
        }
    }
}
