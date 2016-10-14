using System;

namespace Printing
{
  class Program
  {
    static void Main()
    {
      // read input
      int numStudents = int.Parse(Console.ReadLine());
      int sheetsPerStudent = int.Parse(Console.ReadLine());
      double price = double.Parse(Console.ReadLine());
      double realm = 500;

      // logic
      double result = ((numStudents * sheetsPerStudent) / realm) * price;
      
      // print result
      Console.WriteLine("{0:F2}", result);
    }
  }
}
