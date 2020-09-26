using System;
using System.Collections.Generic;

namespace QueueAtSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            string variables = Console.ReadLine();
            string studentsString = Console.ReadLine();

            int n = 0;
            int s = 0;

            string txt = "";
            int c = 0;

            for(int i = 0; i < variables.Length; i++)
            {
                if(variables[i] != ' ')
                {
                    txt += variables[i];
                }
                else
                {
                    if(c == 0)
                    {
                        n = Convert.ToInt32(txt);
                        c++;
                        txt = "";
                    }
                }
            }

            s = Convert.ToInt32(txt);

            List<string> students = new List<string>();

            for(int i = 0; i < studentsString.Length; i++)
            {
                students.Add(studentsString[i].ToString());
            }

            for(int i = 0; i < s; i++)
            {
                for(int j = 0; j < students.Count; j++)
                {
                    if(j != students.Count - 1)
                    {
                        if(students[j] == "B" && students[j + 1] == "G")
                        {
                            students[j] = "G";
                            students[j + 1] = "B";
                            j++;
                        }
                    }
                }
            }


            for(int i = 0; i < students.Count; i++)
            {
                Console.Write(students[i]);
            }

        }
    }
}
