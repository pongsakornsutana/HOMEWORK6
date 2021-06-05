using System;

namespace home_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int score = 5;

            switch (score)
            {

                case 5: Console.WriteLine("A"); break;
                case 4: Console.WriteLine("B"); break;
                case 3: Console.WriteLine("C"); break;
                case 2: Console.WriteLine("D"); break;
                case 1: Console.WriteLine("E"); break;
                default: Console.WriteLine("F"); break;

            }

            Console.ReadLine();

        }

    }
}

