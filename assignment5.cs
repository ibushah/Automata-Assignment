using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            int finalNo;
            Console.Write("No of States: ");
            int n = Convert.ToInt32(Console.ReadLine());
            char[] states = new char[n];
            Console.WriteLine("Enter the States:");
            for(int i=0;i<states.Length;i++)
            {
                states[i]=Convert.ToChar(Console.ReadLine());
            }
            

            Console.WriteLine("No of final states: ");
            finalNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the final states: ");
            char[] finalStates = new char[finalNo];

            for (int i = 0; i < finalStates.Length; i++)
            {
                finalStates[i] = Convert.ToChar(Console.ReadLine());
            }


            char[,] table=new char[n,n];

            Console.WriteLine("\n\nEnter the Table elements");

            Console.WriteLine("\n***********TABLE********\n\n");

           
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(states[i]+": ");
                for (int j = 0; j < 2; j++)
                {
                    table[i,j]=Convert.ToChar(Console.ReadLine());
                }
                Console.WriteLine();
            }


            Console.Clear();
            Console.WriteLine("\n***********TABLE********\n\n");
            Console.WriteLine("   0   1");
            Console.WriteLine("__________");
            for (int i = 0; i < n; i++)
            {
                Console.Write(states[i] + ": ");
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(table[i, j]+" | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("__________\n\n");

            check:

            Console.WriteLine("Enter your string {0,1} :");
            string str = Console.ReadLine();
            int target=0;
            char value='z';
            for (int m = 0; m < str.Length; m++)
            {


                int to = (int)Char.GetNumericValue(str[m]);
                value = table[target,to];
                for(int k=0;k<n;k++)
                {
                    if(value==states[k])
                        target=k;
                }
                

            }
            bool flag=true;

            for (int l = 0; l < finalStates.Length; l++)
            {
                if (value == finalStates[l])
                {
                    Console.WriteLine("String is valid");
                    flag = false;
                    break;
                }
                    
            }

            if (flag)
            {
                Console.WriteLine("Invalid String");
            }


            Console.ReadKey();

            goto check;






            
        }
    }
}
