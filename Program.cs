using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void ForOuneTo()//#1,3
        {
            for (int i = 1; i < 100; i++)
                Console.WriteLine(i);
            /*
             * int i=1;
             * while(i<100)
             * {
             *      Console.WriteLine(i);
             *      i++;
             * }
             */
        }
        static void NProgress(int a)//#2,3
        {
            long f = 1;
            for (int i = 1;i!=a;i++)
                f = f * i;
            /*
             * long i=1,f=1;
             * while(i!=a)
             * {
             *      f=f*i;
             *      i++;
             * }
             */
            Console.Write(a + "!=" + f);
        }
        static void Step(int x ,int n )//#4
        {
            int x1 = x;
            for (int i = 1; i < n; i++)
                x = x * x1;
            Console.Write(x1 + "^" + n + "=" + x);
        }
        static void ArifmeticalProgress()//#5
        {
            int n = 5;
            for (int i = 0; i < 10; i++)
            {
                n = n - 5;
                Console.Write(n + " ");
            }
        }
        static void Figurs()
        {
            int n = 20;
            //1
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == (n / 2 - 1))
                        Console.Write("*");
                    else if (j == 0 || j == (n - 1))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }
            //2
            for (int i = 0; i < n; i++)//2
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || i==(n-1))
                        Console.Write("*");
                    else if (j ==i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }
            //3
            int f = 0;
            for (int i = 0; i < n / 2; i++)//1
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i == n/2-1)||(j==n/2-1-f)||(j==n/2-1+f))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                f++;
                Console.WriteLine("");
            }
            //4
            {
                f = 0;
                for (int i = 0; i < n / 2; i++)//1
                {
                    for (int j = 0; j < n; j++)
                    {
                        if ((j == n / 2  - f) || (j == n / 2  + f))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine("");
                    f++;
                }
                for (int i = n / 2; i < n; i++)//1
                {
                    for (int j = 0; j < n; j++)
                    {
                        if ( (j == n / 2  - f) || (j == n / 2 + f-1))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine("");
                    f--;
                }
            }
        }
        static void Main(string[] args)
        {
            //ForOuneTo();//#1
            //NProgress(3);//#2
            //Step(5,5);//#4
            //ArifmeticalProgress();//#5
            //Figurs();
        }
    }
}
