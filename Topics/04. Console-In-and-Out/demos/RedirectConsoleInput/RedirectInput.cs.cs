using System;
using System.IO;

class RedirectInput
{
    // useful for BgCoder
    static void SetInput()
    {
        string input = @"
first line
second line
pesho
gosho
javascript
c#
";
        Console.SetIn(new StringReader(input));
    }
    
    static void Main()
    {
        SetInput();
        
        string line1 = Console.ReadLine(); // first line
        string line2 = Console.ReadLine(); // second line
        string line3 = Console.ReadLine(); // pesho
    }
}