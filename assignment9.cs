using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibrahim
{
    class Program
    {
        public static int scorer(String str, int[,] states)
        {

            int row = 0;
            int column = 0;


            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'd':
                        column = 0;
                        break;
                    case 'u':
                        column = 1;
                        break;
                    case 'l':
                        column = 2;
                        break;
                    case 'r':
                        column = 3;
                        break;
                }

                row = states[row, column];
            }

            return states[row, 4];
        }

        static void Main(string[] args)
        {
            int[,] table = new int[,]{
            {4,0,0,1,4},
            {5,1,0,2,2},
            {6,2,1,3,9},
            {7,3,2,3,0},
            {8,0,4,5,2},
            {9,1,4,6,8},
            {10,2,5,7,5},
            {11,3,6,7,2},
            {12,4,8,9,1},
            {13,5,8,10,9},
            {14,6,9,11,7},
            {15,7,10,11,6},
            {12,8,12,13,3},
            {13,9,12,14,2},
            {14,10,13,15,1},
            {15,11,11,15,8}
            };
            Console.WriteLine("\n\n*******************TABLE********************\n\n");
            Console.WriteLine("___________________________________________");
            for (int z = 0; z < 16; z++)
            {
                Console.Write("q{0}/{1}       ", z, table[z, 4]);
                if ((z + 1) % 4 == 0)
                    Console.WriteLine("\n");
            }

            Console.WriteLine("--------------------------------------------");


            Console.WriteLine("\nRules:");
            Console.WriteLine("1)Down=d");
            Console.WriteLine("2)Up=u");
            Console.WriteLine("3)Left=l");
            Console.WriteLine("4)Right=r");

            start:

            Console.WriteLine("\n\nPlayer 1 Turn: \n\n");


            Console.WriteLine("Input string 1 :");
            String string1 = Console.ReadLine();
            int p1score1 = scorer(string1, table);
            Console.WriteLine("Input string 2 :");
            String string2 = Console.ReadLine();
            int p1score2 = scorer(string2, table);
            Console.WriteLine("Input string 3 :");
            String string3 = Console.ReadLine();
            int p1score3 = scorer(string3, table);
            int p1Total = p1score1 + p1score2 + p1score3;

            Console.WriteLine("\n\nPLAYER 2 Turn:\n\n");


            Console.WriteLine("Input string 1 :");
            String str1 = Console.ReadLine();
            int p2score1 = scorer(str1, table);
            Console.WriteLine("Input string 2 :");
            String str2 = Console.ReadLine();
            int p2score2 = scorer(str2, table);
            Console.WriteLine("Input string 3 :");
            String str3 = Console.ReadLine();
            int p2score3 = scorer(str3, table);
            int p2Total = p2score1 + p2score2 + p2score3;


            Console.WriteLine("\n\nPlayer 1 Total Score:" + p1Total);
            Console.WriteLine("Player 2 Total Score:" + p2Total);

            if (p1Total > p2Total)
                Console.WriteLine("\n\n**********Player 1 won*************");
            else
                if (p1Total == p2Total)
                    Console.WriteLine("\n\n************Its a tie**********");
                else
                    Console.WriteLine("\n\n************Player 2 won************");

            goto start;
            Console.ReadKey();

        }
    }
}
