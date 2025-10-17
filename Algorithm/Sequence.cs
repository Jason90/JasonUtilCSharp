using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Jason.Algorithm
{
    public class Sequence
    {

        //Fibonacci sequence 输入非负整数 n，返回斐波那契数列的第 n 项（如 n=5 返回 5，n=6 返回 8）
        //1，1，2，3，5，8，13，21，34，55，89
        public static int Fib(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Input must be a non-negative integer.");
            }
            else if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        } 

        //Lucas sequence 输入非负整数 n，返回卢卡斯数列的第 n 项（如 n=5 返回 11，n=6 返回 18）
        //2，1，3，4，7，11，18，29，47，76，123
        public static int Lucas(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Input must be a non-negative integer.");
            }
            else if (n == 0)
            {
                return 2;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Lucas(n - 1) + Lucas(n - 2);
            }
        }
    }
}