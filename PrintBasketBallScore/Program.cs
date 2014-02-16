using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintBasketBallScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;

            Console.WriteLine("Test case 1:");
            printBasketBallScore1(n);

            Console.WriteLine("Test case 2:");
            printBasketBallScore2(n);
        }

        static void printBasketBallScore1(int n)
        {
            StringBuilder sb = new StringBuilder("");
            printBasketBallScore1(n, sb);
        }

        static void printBasketBallScore1(int n, StringBuilder sb)
        {
            if (n < 0)
            {
                return;
            }
            else if (n == 0)
            {
                Console.WriteLine(sb.ToString());
            }
            else
            {
                for (int i = 1; i <= 3; i++)
                {
                    sb.Append(i);
                    printBasketBallScore1(n - i, sb);
                    sb.Remove(sb.Length - 1, 1);
                }
            }
        }

        static void printBasketBallScore2(int n)
        {
            String s = null;
            printBasketBallScore2(n, s);
        }

        static void printBasketBallScore2(int n, string s)
        {
            if (n == 0)
            {
                Console.WriteLine(s);
            }
            else
            {
                for (int i = 1; i <= 3; i++)
                {
                    if (n - i >= 0)
                    {
                        printBasketBallScore2(n - i, s + i);
                    }
                }
            }
        }
    }
}
