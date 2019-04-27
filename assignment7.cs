using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Char[,] table = new Char[,] { { 'A', 'B', '0' }, { 'C', 'B', '0' }, { 'A', 'D', '0' }, { 'C', 'E', '0' }, { 'A', 'B', '1' } };
            Char[] states = new Char[] { 'A', 'B', 'C', 'D', 'E' };
           
            Console.WriteLine("*********Table*********\n\n");

            Console.WriteLine("S | a | b | Out ");
            Console.WriteLine("---------------");
            for (int i = 0; i <5; i++)
            {
                Console.Write(states[i]+" | ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(table[i,j] + " | ");
                }
                Console.WriteLine();
            }

             start:

            Console.WriteLine("\n\nEnter your string:");
            string str = Console.ReadLine();
            int to = 0;
            int row = 0;
            char target = 'A';
            int count = 0;
            for (int k = 0; k < str.Length; k++)
            {

                to=str[k]=='a'? 0:1;

                target = table[row, to];


                if (target == 'A')
                    row = 0;
                else
                    if (target == 'B')
                        row = 1;
                    else
                        if (target == 'C')
                            row = 2;
                        else
                            if (target == 'D')
                                row = 3;
                            else
                                if (target == 'E')
                                    row = 4;


                count+= (int)Char.GetNumericValue(table[row, 2]);

            }

            Console.WriteLine("babb has occured " + count +" Times");
            goto start;



        }
    }
}
