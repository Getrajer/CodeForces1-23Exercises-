using System;
using System.Collections.Generic;

namespace Contestants
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine().ToString();
            string secondInput = Console.ReadLine().ToString();

            int n = 0;
            int k = 0;

            bool mode1 = true;
            string s_n = "";
            string s_k = "";

            for(int i = 0; i < firstInput.Length; i++)
            {
                if (mode1)
                {
                    if (firstInput[i] != ' ')
                    {
                        s_n += firstInput[i];
                    }
                    else
                    {
                        mode1 = false;
                    }
                }
                else
                {
                    s_k += firstInput[i];
                }
            }

            n = Convert.ToInt32(s_n);
            k = Convert.ToInt32(s_k);

            string s_nr = "";
            List<int> pointsBoard = new List<int>();

            for(int i = 0; i < secondInput.Length; i++)
            {
                if(secondInput[i] != ' ')
                {
                    s_nr += secondInput[i];

                    if(secondInput.Length - 1 == i)
                    {
                        pointsBoard.Add(Convert.ToInt32(s_nr));
                        s_nr = "";
                    }
                }
                else
                {
                    pointsBoard.Add(Convert.ToInt32(s_nr));
                    s_nr = "";
                }
            }

            int drawCounter = 0;
            int passed = 0;
            int previous = 0;

            for(int i = 0; i < pointsBoard.Count; i++)
            {
                if(i == 0)
                {
                    previous = pointsBoard[i];
                }

                if(pointsBoard[i] == previous && pointsBoard[i] > 0)
                {
                    drawCounter++;
                    previous = pointsBoard[i];
                }
                
                if(pointsBoard[i] > k)
                {
                    passed++;
                }
            }

            if (drawCounter == pointsBoard.Count)
            {
                Console.WriteLine(drawCounter);
            }
            else
            {
                Console.WriteLine(passed);
            }
        }
    }
}
