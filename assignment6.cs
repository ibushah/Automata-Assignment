using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {



        static void Main(string[] args)
        {

            Console.WriteLine("Mod:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] function = new int[n, 3];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the State {0} Elements",i+1);
                function[i, 0] = Convert.ToInt32(Console.ReadLine());
                function[i, 1] = Convert.ToInt32(Console.ReadLine());
               
                function[i, 2] = i;
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

           
         
           
            for (int i = 0; i < n; i++)
            {
               
                for (int j = 0; j < 3; j++)
                {
                
                    Console.Write("{0}   ", function[i, j]);
                }

                Console.WriteLine();
            }
           

            back:

            Console.WriteLine("Enter your desired No:");
            int no = Convert.ToInt32(Console.ReadLine());
           String quotient = Convert.ToString(no,2);

          Console.WriteLine("Binary: {0}",quotient);

          
          int to = 0;
          int r = 0;



          for (int i = 0; i < quotient.Length; i++)
          {
              to = function[r, (int)char.GetNumericValue(quotient[i])];
              r = to;
          }

           
          

         Console.WriteLine("Result:{0}", function[to, 2]);


        
         goto back ;


            Console.ReadKey();





        }
    }
}
