namespace PeshosMaze
{
    using System;
    using System.Diagnostics;
    using System.Text;

    public class PeshosMaze
    {
        public static void Main()
        {
            // constants & configuration
            const char wallSymbol = '█';
            const char player = '☻';
            const char coin = '©';

            const int escapeX = 14;
            const int escapeY = 1;

            const int consoleWidth = 16;
            const int consoleHeight = 8;

            const ConsoleColor defaultBackgroundColor = ConsoleColor.White;
            const ConsoleColor defaultForegroundColor = ConsoleColor.Black;
            const ConsoleColor playerColor = ConsoleColor.DarkGreen;

            // console prep
            Console.BackgroundColor = defaultBackgroundColor;
            Console.Clear();

            Console.WindowHeight = consoleHeight;
            Console.BufferHeight = consoleHeight;

            Console.WindowWidth = consoleWidth;
            Console.BufferWidth = consoleWidth;

            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;

            // setup the data
            string[] maze = new string[]
            {
                "███████████████",
                "█ ©   █        ",
                "█   █████████ █",
                "█     █©      █",
                "█  ███████  ███",
                "█             █",
                "███████████████"
            };

            // player stats
            int playerX = 1;
            int playerY = 5;
            int coinsCollected = 0;

            // timer
            Stopwatch timer = new Stopwatch();
            timer.Start();

            // while the player is in the maze, print, read and handle input
            while (playerX != escapeX || playerY != escapeY)
            {
                // check if the player is standing on a coin
                if (maze[playerY][playerX] == coin)
                {
                    coinsCollected++;
                    maze[playerY] = maze[playerY].Replace(coin, ' ');
                }

                // print the maze
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = defaultForegroundColor;
                Console.Write(string.Join(Environment.NewLine, maze));

                // print the player
                Console.SetCursorPosition(playerX, playerY);
                Console.ForegroundColor = playerColor;
                Console.Write(player);

                // read user input
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // move if there is not a wall in our way
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:

                        if (maze[playerY - 1][playerX] != wallSymbol)
                        {
                            playerY--;
                        }

                        break;
                    case ConsoleKey.DownArrow:

                        if (maze[playerY + 1][playerX] != wallSymbol)
                        {
                            playerY++;
                        }

                        break;
                    case ConsoleKey.RightArrow:

                        if (maze[playerY][playerX + 1] != wallSymbol)
                        {
                            playerX++;
                        }

                        break;
                    case ConsoleKey.LeftArrow:

                        if (maze[playerY][playerX - 1] != wallSymbol)
                        {
                            playerX--;
                        }

                        break;
                    default:
                        break;
                }

            }

            timer.Stop();
            string message = timer.Elapsed.Seconds <= 15 ? "You win!" : "Be faster!";
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(message);
            Console.WriteLine("{0} seconds, {2} {1} coins collected", timer.Elapsed.Seconds, coinsCollected, Environment.NewLine);
        }
    }
}
