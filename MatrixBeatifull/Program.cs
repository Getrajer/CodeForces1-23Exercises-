using System;

namespace MatrixBeatifull
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];

            int posX = 0;
            int posY = 0;

            for(int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();
                int position_c = 0;

                for(int j = 0; j < input.Length; j++)
                {
                    if(input[j] != ' ')
                    {
                        matrix[i, position_c] = Convert.ToInt32(input[j]);
                        if (input[j] == '1')
                        {
                            posX = i;
                            posY = position_c;
                        }
                        position_c++;
                    }
                }
            }

            int moves = 0;
            bool onPosition = false;

            while (!onPosition)
            {
                if(posX != 2)
                {
                    if(posX < 2)
                    {
                        posX++;
                        moves++;
                        continue;
                    }
                    else
                    {
                        posX--;
                        moves++;
                        continue;
                    }
                }

                if(posY != 2)
                {
                    if (posY < 2)
                    {
                        posY++;
                        moves++;
                        continue;
                    }
                    else
                    {
                        posY--;
                        moves++;
                        continue;
                    }
                }

                if(posY == 2 && posX == 2)
                {
                    onPosition = true;
                }
            }

            Console.WriteLine(moves);
        }
    }
}
