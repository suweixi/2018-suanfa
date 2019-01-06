using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            // DecryptTheQQNumber("44724302");

            PerfectMat();  //显示完美数

            // Console.WriteLine("请输入回文");
            //Console.WriteLine(DecryptionPalindrome(Console.ReadLine()));

            //Console.WriteLine(factorial(5).ToString());
            //Console.WriteLine(Fibonacci(5).ToString());
            Console.ReadKey();
        }
        #region 寻找完美数
        //寻找完美数
        public static void PerfectMat()
        {

            int i, j, sum, a = 0;
            for (i = 1; i < 10000; i++)
            {
                sum = 0;
                for (j = 1; j <= i / 2 + 1; j++)
                {
                    a = i % j;
                    if (a == 0 && i != j)
                        sum = sum + j;
                }
                if (sum == i)
                    Console.WriteLine("这是一个完美数:" + sum.ToString());
            }
        }
        #endregion

        #region 解密QQ号
        public static void DecryptTheQQNumber(string QQNumber)
        {
            //声明一个队列
            Queue clear = new Queue();
            //将传递过来的参数复制给队列clear
            foreach (var item in QQNumber)
            {
                clear.Enqueue(item);
            }
            //进行循环
            for (int i = 0; i < QQNumber.Length; i++)
            {
                //如果队列只剩下一位，直接输出，并跳出循环
                if (clear.Count == 1)
                {
                    Console.Write(clear.Dequeue());
                    break;
                }
                //输出队列的第一位
                Console.Write(clear.Dequeue());
                //将队列的第一位放到最后
                clear.Enqueue(clear.Dequeue());
            }
        }
        #endregion

        #region 解密回文
        public static string DecryptionPalindrome(string chars)
        {
            //声明一个栈
            Stack stack = new Stack();
            Stack mirroring = new Stack();
            //将传递过来的string型注入栈中
            foreach (var item in chars)
            {
                stack.Push(item);
            }
            //将栈的一半值赋值给另一个栈
            for (int i = 0; i < chars.Length / 2; i++)
            {
                mirroring.Push(stack.Pop());
            }
            //判断chars的原始数据长度是奇数还是偶数
            if (stack.Count != mirroring.Count)
            {
                stack.Pop();
            }
            //通过长度去判断两个栈的值是否相等
            for (int i = 0; i < stack.Count + mirroring.Count; i++)
            {
                if (mirroring.Pop().ToString() != stack.Pop().ToString())
                {
                    return "这不是回文";
                }
            }
            return "这是回文";

        }
        #endregion

        #region 阶乘
        public static int factorial(int transmit)
        {
            //递归边界
            if (transmit <= 1)
            {
                return 1;
            }
            //返回 transmit 并再次调用方法 factorial
            return transmit * factorial(transmit - 1);
        }
        #endregion

        #region Fibonacci
        public static int Fibonacci(int i)
        {
            return i <= 1 ? 1 : Fibonacci(i - 1) + Fibonacci(i - 2);
        }
        #endregion

        #region Ackerman
        public static int Ackerman(int n, int m)
        {
            if (n == 1 && m == 0)
            {
                return 2;
            }
            if (n == 0)
            {
                return 1;
            }
            if (m == 0)
            {
                return n + 2;
            }
            return Ackerman(Ackerman(n - 1, m), m - 1);
        }
        #endregion

        #region 插入排序
        public static int[] insertionSort(int[] array)
        {
            int[] change = new int[array.Length];
            return null;
        }

        #endregion

        #region 递归排列问题
        public static Stack Arrange(int[] original)
        {
            Stack change = new Stack();
            if (change.Count != original.Length)
            {

            }
            return null;
        }
        #endregion
    }
}


