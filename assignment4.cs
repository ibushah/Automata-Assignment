using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static string[] splitter(string abc)
        {
            string[] arr = new string[50];
            int j = 0;

            for (int i = 0; i < abc.Length; i++)
            {
                if (abc[i] != '{' && abc[i] != '}')
                {
                    if (abc[i] != ',')
                    {
                        arr[j] += abc[i];
                    }
                    else if (abc[i] == ',')
                    {
                        j++;
                    }

                }
            }

            return arr;
        }

        public static int len(string[] a)
        {
            int length = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != null)
                {
                    length++;
                }
            }
            return length;
        }
        public static int power(int n, int p)
        {
            if (n == 0)
            {
                return 0;
            }
            else
                if (p == 0)
                {
                    return 1;
                }
                else
                {
                    int res = 1;
                    for (int i = 1; i <= p; i++)
                    {
                        res *= n;
                    }
                    return res;
                }
        }
        public static void results(int n, int till, string[] lang)
        {
            for (int i = 0; i < power(2, n); i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int res = till != 0 ? i / power(2, till) % 2 : i % 2;

                    Console.Write(lang[res] + " ");
                    till--;
                }
                Console.WriteLine();
                till = n - 1;


            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your 2 alphabets");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the length,enter -1 to see all possible results");
            int n = Convert.ToInt32(Console.ReadLine());


            string[] lang = splitter(str);
            int length = len(lang);
            int till = n - 1;


            if (n == 0)
            {
                Console.WriteLine("\n^");
            }
            else
                if (length == 2 && n > 0)
                {
                    Console.WriteLine("\n\n *********POSSIBLE RESULTS********\n\n");

                    results(n, till, lang);
                }
                else
                    if (length == 2 && n == -1)
                    {
                        Console.WriteLine("\n\n *********ALL POSSIBLE RESULTS********\n\n");

                        Console.WriteLine("^");
                        results(1, 0, lang);
                        results(2, 1, lang);
                        results(3, 2, lang);
                        results(4, 3, lang);
                        Console.WriteLine("......");
                    }
                    else
                    {
                        Console.WriteLine("\n\nThe input string is not in correct format or the length specified is not right");
                    }



            Console.ReadKey();
        }
    }
}
