using System;

namespace AWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            int nrLower = 0;
            int nrUpper = 0;

            for(int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    nrLower++;
                }

                if (char.IsUpper(input[i]))
                {
                    nrUpper++;
                }
            }

            if(nrLower == nrUpper)
            {
                Console.WriteLine(input.ToLower());
            }
            else if(nrLower > nrUpper)
            {
                Console.WriteLine(input.ToLower());
            }
            else
            {
                Console.WriteLine(input.ToUpper());
            }

        }
    }
}
