using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter the list of elements");
                string[] arr = new string[50];
                int j = 0;
                string str = Console.ReadLine();

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != '{' && str[i] != '}')
                    {
                        if (str[i] != ',')
                        {
                            arr[j] += str[i];
                        }
                        else if (str[i] == ',')
                        {
                            j++;
                        }

                    }
                }

                bool flag = false;
                string temp = "";

                for (int l = 0; l < arr.Length; l++)
                {
                    if (arr[l] != null)
                    {
                        for (int m = l + 1; m < arr.Length; m++)
                        {
                            if (arr[m] != null)
                            {
                                temp = "";
                                if (arr[l].Length <= arr[m].Length)
                                {
                                    for (int k = 0; k < arr[l].Length; k++)
                                    {
                                        temp += arr[m][k];
                                    }
                                    if (temp == arr[l])
                                    {
                                        flag = true;

                                    }
                                }
                                else
                                {
                                    for (int k = 0; k < arr[m].Length; k++)
                                    {
                                        temp += arr[l][k];
                                    }
                                    if (temp == arr[m])
                                    {
                                        flag = true;
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                        }

                    }
                    else
                    {
                        break;
                    }
                }
            

                if (flag == true)
                {
                    Console.WriteLine("INVALID");
                }
                else
                {
                    Console.WriteLine("VALID");
                }

            
           
            Console.ReadKey();
        }
    }
}
