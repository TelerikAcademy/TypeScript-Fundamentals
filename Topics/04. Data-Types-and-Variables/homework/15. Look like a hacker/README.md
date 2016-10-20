# Look like a hacker

## Preliminaries
If you haven't done the Command line task from the previous homework, go back and do it.

## Description
Hackers look cool, don't they? They do all kinds of dizzying confusing stuff on their computers that looks like magic. You can also look cool like a hacker, if you complete the task below. **Use only the terminal, unless the description says otherwise**.
- Open a terminal in a folder of your choice
- Make a directory named `im-cool` from the terminal
- Navigate the terminal into the new directory
- Create a file named `ImCool.cs`
- Enter `ImCool.cs` in the terminal
    - This should open the `ImCool.cs` file with the default program for `.cs` files(should be Visual Studio on Windows)
- Write some C# code in `ImCool.cs`
    - Declare a few variables, assign them some value, print them. For example:
    ```csharp
    using System;

    class ImCool
    {
        static void Main()
        {
            string amICool = "Absolutely";
            Console.WriteLine(amICool);
        }
    }
    ```
- Next, run the command `csc ImCool.cs`
    - `csc` is the command to use the C# compiler from the terminal
    - This command will probably not be successful the first time you run it and you will probably see this output
    ```
    'csc' is not recognized as an internal or external command,
    operable program or batch file.
    ```
    - You will need to find where the `csc.exe` is on your computer and copy the path to it's folder
    - Next, you will need to put this path in the **PATH** of you Windows(you're not required to do this in the terminal)
        - Research on the internet how to add something to the PATH of Windows, where to find the C# compiler executable(`csc.exe`)
    - **If you can't get it working after researching for a fair bit, have another student help you or write a question in our forums**
- After you've successfully ran the command `csc ImCool.cs`, list all files in the directory(using `dir` or `ls`)
    - You'll notice that a file named `ImCool.exe` has appeared - you have successfuly compiled a C# file from the terminal. Good job!
- To run the C# program you just compiled, run the command `ImCool.exe`
    - You will be able to see the output of your program in the terminal

## Submission
You do not have to submit anything for this problem.