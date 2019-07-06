using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {

        public static int value(Char a)
        {
            if (a == '-' || a == '+')
                return 1;
            else
                if (a == '*' || a == '/')
                    return 2;
                else
                    if (a == '^')
                        return 3;
                    else
                    {
                        return -1;
                    }
            
        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("\n\n");

            Console.WriteLine("Enter your Expression");
            String exp = Console.ReadLine();

            Stack<Char> s = new Stack<Char>();
            Stack<String> eval = new Stack<String>();
            String res="";
          

            for (int i = 0; i < exp.Length; i++)
            {

                if (char.GetNumericValue(exp[i]) >= 0 && char.GetNumericValue(exp[i]) <= 9)
                {
                    
                    res += exp[i];
                }
                else
                    if (exp[i] == '(')
                    {
                        s.Push(exp[i]);
                    }
                    else
                        if (exp[i] == ')')
                        {

                            while(s.Peek()!= '(')
                            {
                                Char v = s.Pop();
                                res += v;
                            }
                            s.Pop();  
                        }
                        else
                        {
                            if (s.Count == 0)
                            {
                                s.Push(exp[i]);

                            }
                            else
                            {
                                while (s.Count != 0 && value(s.Peek()) >= value(exp[i]))
                                {
                                    Char x = s.Pop();
                                    res += x;
                                }
                                s.Push(exp[i]);

                            }
                        }

                
            }
             int first,second,derived;
            foreach (Char x in s)
            {
                res += x;
            }



            for (int j = 0; j < res.Length; j++)
            {


                if (res[j] == '*' || res[j] == '/' || res[j] == '+' || res[j] == '-' || res[j] == '^')
                {
                    if (res[j] == '*')
                    {
                        second = int.Parse(eval.Pop());
                        first = int.Parse(eval.Pop());
                        derived = first * second;
                        eval.Push(derived.ToString());

                    }
                    else
                        if (res[j] == '/')
                        {
                            second = int.Parse(eval.Pop());
                            first = int.Parse(eval.Pop());
                            derived = first / second;
                            eval.Push(derived.ToString());

                        }
                        else
                            if (res[j] == '+')
                            {
                                second = int.Parse(eval.Pop());
                                first = int.Parse(eval.Pop());
                                derived = first + second;
                                eval.Push(derived.ToString());
                            }
                            else
                                if (res[j] == '-')
                                {
                                    second = int.Parse(eval.Pop());
                                    first = int.Parse(eval.Pop());
                                    derived = first - second;
                                    eval.Push(derived.ToString());
                                }
                                else
                                {
                                    second = int.Parse(eval.Pop());
                                    first = int.Parse(eval.Pop());
                                    derived = Convert.ToInt32(Math.Pow(first, second));
                                    eval.Push(derived.ToString());
                                }

                }
                else
                {
                    eval.Push(res[j].ToString());
                }
            }




            

            Console.WriteLine(res);

            foreach (String a in eval)
                Console.WriteLine("Result:===> " + a);


            goto start;

            Console.ReadLine();
            
           
        }
    }
}
