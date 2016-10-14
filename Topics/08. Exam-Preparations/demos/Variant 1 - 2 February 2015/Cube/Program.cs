using System;
namespace Cube
{
  class Program
  {
    static void Main()
    {
      // read input
      int n = 9; // int.Parse(Console.ReadLine());
      int fieldSize = n * 2 - 1;
      int mid = n - 1; 
       
      char empty = ' ';
      char top = '/';
      char side = 'X';
      char edge = ':'; 

      for (int row = 0; row < fieldSize; row++)
      {
        for (int col = 0; col < fieldSize; col++)
        {
          if (col == 0 && row >= mid || // bott left side
              col == mid && row >= mid || // bott right side
              col == fieldSize - 1 && row <= mid ||
              col >= mid && row == 0 ||
              col <= mid && row == mid ||
              col <= mid && row == fieldSize - 1 ||
              col + row == mid ||
              col + row == fieldSize - 1 + mid ||
              col + row == fieldSize - 1 && row <= mid)
          { // edges
            Console.Write(edge);
          }
          else if (col > mid &&
                   col + row <= fieldSize - 1 + mid &&
                   col + row >= fieldSize - 1)
          {
            Console.Write(side);
          }
          else if (row < mid &&
                   col + row >= mid)
          {
            Console.Write(top);
          }
          else
          {
            Console.Write(empty);
          }
        }

        Console.WriteLine();
      }
    }
  }
}
