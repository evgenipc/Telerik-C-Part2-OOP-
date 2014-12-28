using System;

class StartToFinishProgram
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        for (int i = 0; i < 10; i++)
        {
            start = ReadNumber(start, end);
        }
        Console.WriteLine(ReadNumber(start, end));
    }
    static int ReadNumber(int start, int end)
    {
        Console.WriteLine("Enter a number between {0} and {1}", start, end);
        int number = int.Parse(Console.ReadLine());

        if (number <= start || number >= end)
        {
            throw new System.ArgumentOutOfRangeException();
        }
        return number;
    }
}
