using System;

namespace Capitalize
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string newString = input[0].ToString().ToUpper();

            for(int i = 1; i < input.Length; i++)
            {
                newString += input[i];
            }


            Console.WriteLine(newString);

        }
    }
}
