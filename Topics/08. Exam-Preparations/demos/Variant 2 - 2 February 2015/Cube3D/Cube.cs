namespace Cube3D
{
    using System;

    public class Cube
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            // allocate a char matrix with the appropriate size
            // using a matrix because Console.SetCursorPosition doesn't work with redirected output in bgcoder
            char[,] cube = new char[2 * N - 1, 2 * N - 1];

            // matrix: How to give a cell a value
            // cube[1, 1] = 'a';

            // loop for cube outline
            for (int i = 0; i < N; i++)
            {
                // upper horizontal side
                //Console.SetCursorPosition(i, 0);
                //Console.Write(':');
                cube[0, i] = ':';


                // bottom horizontal side
                //Console.SetCursorPosition(i, N - 1);
                //Console.Write(':');
                cube[N - 1, i] = ':';

                // left vertical side
                //Console.SetCursorPosition(0, i);
                //Console.Write(':');
                cube[i, 0] = ':';

                // right vertical side
                //Console.SetCursorPosition(N - 1, i);
                //Console.Write(':');
                cube[i, N - 1] = ':';

                // hind bottom horizontal side
                //Console.SetCursorPosition(i + N - 1, 2 * (N - 1));
                //Console.Write(':');
                cube[2 * (N - 1), i + N - 1] = ':';

                // hind right vertical side
                //Console.SetCursorPosition(2 * (N - 1), i + N - 1);
                //Console.Write(':');
                cube[i + N - 1, 2 * (N - 1)] = ':';

                // top right side
                //Console.SetCursorPosition(N - 1 + i, i);
                //Console.Write(':');
                cube[i, N - 1 + i] = ':';

                // bottom right side
                //Console.SetCursorPosition(N - 1 + i, N - 1 + i);
                //Console.Write(':');
                cube[N - 1 + i, N - 1 + i] = ':';

                // bottom left side
                //Console.SetCursorPosition(i, N - 1 + i);
                //Console.Write(':');
                cube[N - 1 + i, i] = ':';
            }

            for (int i = 2; i < N; i++)
            {
                // this is how we discovered the zavisimost
                //Console.SetCursorPosition(N, i);
                //Console.Write('|');

                //Console.SetCursorPosition(N + 1, i + 1);
                //Console.Write('|');

                //Console.SetCursorPosition(N + 2, i + 2);
                //Console.Write('|');

                // fill right cube side with |
                for (int j = 0; j < N - 2; j++)
                {
                    //Console.SetCursorPosition(N + j, i + j);
                    //Console.Write('|');
                    cube[i + j, N + j] = '|';
                }

                // fill right cube side with -
                for (int j = 0; j < N - 2; j++)
                {
                    //Console.SetCursorPosition(i + j, N + j);
                    //Console.Write('-');
                    cube[N + j, i + j] = '-';
                }
            }

            for (int row = 0; row < 2 * N - 1; row++)
            {
                for (int column = 0; column < 2 * N - 1; column++)
                {
                    char symbol = cube[row, column];

                    if (symbol != 0)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }

            //Console.SetCursorPosition(20, 20);
            //Console.WriteLine();
        }
    }
}
