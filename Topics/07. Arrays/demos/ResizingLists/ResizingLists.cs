using System;
using System.Collections.Generic;

public class ResizingLists
{
    static void Main()
    {
        List<int> list = new List<int>();
        int n = int.Parse(Console.ReadLine());

        string lineBreak = new string('-', 20);

        for (int i = 0; i < n + 1; i++)
        {
            var capacity = list.Capacity;
            var count = list.Count;
            Console.WriteLine("Total Capacity of the List: {0}\nused:{1}\n{2}",
                capacity, count, lineBreak);
            list.Add(i);
        }
    }
}
