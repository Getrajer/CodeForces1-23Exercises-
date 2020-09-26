using System;

namespace Dominos
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string s_m = "";
            string s_x = "";

            bool first = true;

            for(int i = 0; i < input.Length; i++)
            {
                if (first)
                {
                    if(input[i] != ' ')
                    {
                        s_m += input[i];
                    }
                    else
                    {
                        first = false;
                    }
                }
                else
                {
                    s_x += input[i];
                }
            }

            int m = Convert.ToInt32(s_m);
            int x = Convert.ToInt32(s_x);

            int result = (m * x) / 2;

            Console.WriteLine(result);

        }
    }
}
