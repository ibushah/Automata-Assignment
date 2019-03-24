using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
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

        public static bool valid(string[] arr)
        {
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
            return flag;
            
        }

        public static void reverse(string[] v,string s,int len)
        {
            
            string[] r=new string[50];
           
            int k = 0;
            
            for(int x=0;x<s.Length;x++)
            {
                for(int y=0;y<len;y++)
                {
                    if (x + v[y].Length <= s.Length)
                    {
                        if (s.Substring(x, v[y].Length) == v[y])
                        {
                            r[k] = v[y];
                            k++;
                        }
                    }
                    
                   
                }
            }
            for (int d = k-1; d >= 0; d--)
            {
                if (r[d] != null)
                {
                    Console.Write(r[d]," ");
                }
            }
        }
        static void Main(string[] args)
        {
            string[] rev = new string[50];
            int revKey = 0;
            Console.WriteLine("Enter the Language");
           
           

            string s = Console.ReadLine();
            string[] lan = splitter(s);
            int length = len(lan);
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string str2 = str;
            int m=0, check = 0 ;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (lan[i][0] == str[j])
                    {
                        m = j;
                        check = 0;
                        for (int x = 0; x < lan[i].Length; x++)
                        {


                            if (m < str.Length && lan[i][x] == str[m])
                            {
                                check++;
                            }
                            m++;

                        }

                        if (check == lan[i].Length)
                        {
                            rev[revKey] = str.Substring(j, check);
                            str = str.Remove(j,check);
                            i = 0;
                            revKey++;
                        }
                    }
                    
                }
            }
            Console.WriteLine(str);
            if (lan[0] == null)
            {
                Console.WriteLine("INVALID");
            }
            else
            {
                if (valid(lan) == false && str.Length == 0)
                {
                    Console.WriteLine("VALID");

                    reverse(lan, str2,len(lan));
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }


           
            Console.ReadKey();
        }
    }
}
