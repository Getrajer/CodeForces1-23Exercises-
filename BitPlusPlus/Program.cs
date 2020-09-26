using System;

namespace BitPlusPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            int x = 0;

            for(int i = 0; i < n; i++)
            {
                string action = Console.ReadLine();

                int c_plus = 0;
                int c_minus = 0;

                for(int j = 0; j < action.Length; j++)
                {
                    if(action[j] == '+')
                    {
                        c_plus++;
                    }

                    if(action[j] == '-')
                    {
                        c_minus++;
                    }
                }

                if(c_plus == 2)
                {
                    x++;
                }

                if(c_minus == 2)
                {
                    x--;
                }
            }

            Console.WriteLine(x);
        }
    }
}
