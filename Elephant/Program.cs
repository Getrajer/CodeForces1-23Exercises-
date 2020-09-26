using System;

namespace Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = Convert.ToInt32(Console.ReadLine());

            int steps = 0;

            for( int i = 0; i < 1;)
            {
                if (distance - 5 >= 0)
                {
                    distance -= 5;
                    steps++;
                }
                else if (distance - 4 >= 0)
                {
                    distance -= 4;
                    steps++;
                }
                else if( distance - 3 >= 0)
                {
                    distance -= 3;
                    steps++;
                }
                else if(distance - 2 >= 0)
                {
                    distance -= 2;
                    steps++;
                }
                else if(distance - 1 >= 0)
                {
                    distance -= 1;
                    steps++;
                }

                if (distance == 0) i++;
            }

           

            Console.WriteLine(steps);

        }
    }
}
