using System;
using System.IO;

class ReadFileProgram
{
    static void Main()
    {
        string path = @"C:\WINDOWS\win.ini";
        try
        {
            Console.WriteLine(File.ReadAllText(path));
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: \n{0}:{1}", e.GetType().Name, e.Message);
        }

    }
}
