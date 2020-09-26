using System;

namespace AntonOrDanik
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = Convert.ToInt32(Console.ReadLine());
            string games = Console.ReadLine();

            int a = 0;
            int d = 0;

            for(int i = 0; i < games.Length; i++)
            {
                if (games[i] == 'A') a++; else d++;
            }

            if (a > d)
            {
                Console.WriteLine("Anton");
            }
            else if(d > a)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");
            }

        }
    }
}
