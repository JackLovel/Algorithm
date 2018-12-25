using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        public static double Evaluate(string inStr)
        {
            Stack<string> ops = new Stack<string>();
            Stack<double> vals = new Stack<double>();
            inStr = inStr.Replace(" ", "");
            char[] arr = inStr.ToCharArray();

            foreach (char c in arr)
            {
                string s = c + "";
                if (s.Equals("("))
                {
                    ;
                }
                else if (s.Equals("+"))
                {
                    ops.Push(s);
                }
                else if (s.Equals("-"))
                {
                    ops.Push(s);
                }
                else if (s.Equals("*"))
                {
                    ops.Push(s);
                }
                else if (s.Equals("+"))
                {
                    ops.Push(s);
                }
                else if (s.Equals("/"))
                {
                    ops.Push(s);
                }
                else if (s.Equals("sqrt"))
                {
                    ops.Push(s);
                }
                else if (s.Equals(")"))
                {
                    string op = ops.Pop();
                    double v = vals.Pop();
                    if (op.Equals("+"))
                    {
                        v = vals.Pop() + v;
                    }
                    else if (op.Equals("-"))
                    {
                        v = vals.Pop() - v;
                    }
                    else if (op.Equals("*"))
                    {
                        v = vals.Pop() * v;
                    }
                    else if (op.Equals("/"))
                    {
                        v = vals.Pop() / v;
                    }
                    else if (op.Equals("sqrt"))
                    {
                        v = Math.Sqrt(v);
                    }
                    vals.Push(v);
                }
                else vals.Push(double.Parse(s));
            }
            return vals.Pop();
        }

        static void Main(string[] args)
        {
            string expr  = "(1 + ((2 + 3) * (4 * 5)))";
            Console.WriteLine("{0} = {1}", expr, Evaluate(expr));

            string expr2 = "(1+2)";
            Console.WriteLine("{0} = {1}", expr2, Evaluate(expr2));

            Console.ReadKey();
        }   
    }
}
