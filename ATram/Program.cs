using System;

namespace ATram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] numbers = new int[n, 2];

            for(int i = 0; i < n; i++)
            {
                string txt = Console.ReadLine();
                string part = "";
                int c = 0;

                for(int j = 0; j < txt.Length; j++)
                {
                    if(txt[j] != ' ')
                    {
                        part += txt[j];
                    }
                    else
                    {
                        if(c == 0)
                        {
                            numbers[i, c] = Convert.ToInt32(part);
                            part = "";
                            c++;
                        }
                    }
                }

                numbers[i, c] = Convert.ToInt32(part);
            }

            int higest = 0;
            int temp = 0;

            for(int i = 0; i < n; i++)
            {
                temp += -numbers[i, 0] + numbers[i, 1];

                if(temp > higest)
                {
                    higest = temp;
                }
            }


            Console.WriteLine(higest);

        }
    }
}
