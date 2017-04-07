using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScore
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] name = new string[10] { "david6", "david3", "david5", "david9", "david1", "david0", "david4", "david2", "david7", "david8" };
            int[] score = new int[10] { 6, 3, 5, 9, 1, 0, 4, 2, 7, 8 };

            for (int d = 0; d < score.Length; d++)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (score[i] > score[i + 1])
                    {
                        string guardarname = name[i];
                        name[i] = name[i + 1];
                        name[i + 1] = guardarname;

                        int guardarscore = score[i];
                        score[i] = score[i + 1];
                        score[i + 1] = guardarscore;
                    }
                }
            }

            foreach (int n in score)
            {
                Console.WriteLine(name[n] + " " + score[n]);
            }
            Console.ReadKey();
        }
    }
}
