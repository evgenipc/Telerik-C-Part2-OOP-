using System;

    class SquareRootProgram
    {
        static void Main()
        {
            Console.Write("Vuvedete chislo:");
            string str = Console.ReadLine();
            try
            {
                uint.Parse(str);

                Console.WriteLine(Math.Sqrt(uint.Parse(str)));
                Console.WriteLine("Good bye");

            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid number!");
                Console.WriteLine("Good bye");


            }

        }
    }

