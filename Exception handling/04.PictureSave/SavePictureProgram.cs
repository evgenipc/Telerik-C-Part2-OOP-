using System;
using System.IO;
using System.Net;

class SavePictureProgram
{
    static void Main()
    {
        string startupPath = Environment.CurrentDirectory;
        WebClient webClient = new WebClient();

        try
        {
            webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @startupPath);
            Console.WriteLine("Everything is ok!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: \n{0}:{1}", e.GetType().Name, e.Message);
            throw e;
        }

    }
}
