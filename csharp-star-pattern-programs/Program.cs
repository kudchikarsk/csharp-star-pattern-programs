using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_star_pattern_programs
{
    class Program
    {
        private static int number = 1;

        static void Main(string[] args)
        {
            Heading();
            Pattern1();

            Heading();
            Pattern2();

            Heading();
            Pattern3();

            Heading();
            Pattern4();

            Heading();
            Pattern5();

            Heading();
            Pattern6();

            Heading();
            Pattern7();

            Heading();
            Pattern8();

            Heading();
            Pattern9();

            Heading();
            Pattern10();

            Heading();
            Pattern11();

            Heading();
            Pattern12();

            Heading();
            Pattern13();

            Heading();
            Pattern14();

            Console.ReadLine();
        }          

        private static void Pattern1()
        {
            for (int row = 8; row >= 1; --row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        private static void Pattern2()
        {
            for (int row = 1; row <= 8; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        private static void Pattern3()
        {
            int number = 8, count = 1;
            count = number - 1;
            for (var k = 1; k <= number; k++)
            {
                for (var i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (var i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (var k = 1; k <= number - 1; k++)
            {
                for (var i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (var i = 1; i <= 2 * (number - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        private static void Pattern4()
        {
            int val = 8;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        private static void Pattern5()
        {
            int size = 8;

            for (int row = 1; row <= size; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write(" ");
                }

                for (int col = 1; col <= size; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        private static void Pattern6()
        {
            int number = 7;

            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == 6)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (i >= 1 && i <= 5)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (j == 0 || j == 6)
                        {
                            Console.Write("*");
                        }
                        else if (j >= 1 && j <= 5)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void Pattern7()
        {
            int n = 8;

            for (int i = 0; i < n; ++i)
            {
                Stars(i + 1);
                Spaces(n - i - 1);
                Stars(n - i + 1);
                Spaces(2 * i);
                Stars(n - i);
                Spaces(n - i - 1);
                Stars(i + 1);

                Console.WriteLine();
            }
        }

        private static void Stars(int count)
        {
            for (int i = 0; i < count; ++i)
                Console.Write("*");
        }

        private static void Spaces(int count)
        {
            for (int i = 0; i < count; ++i)
                Console.Write(" ");
        }

        private static void Pattern8()
        {
            int x = 8;
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= (x - i); j++)
                    Console.Write(" ");

                for (int t = 1; t < i * 2; t++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        private static void Pattern9()
        {
            int space = 0;
            int max = 10;


            for (var i = max; i > 0; i--)
            {

                for (var j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                for (var j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }

                for (var j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                space += 2;
            }
        }

        private static void Pattern10()
        {
            int max = 10;
            for (var i = 1; i <= max; i++)
            {
                for (var j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == max)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void Pattern11()
        {
            int max = 8;
            for (var i = 1; i <= max; i++)
            {
                for (var j = i; j < max; j++)
                {
                    Console.Write(" ");
                }
                for (var j = 1; j <= (2 * i - 1); j++)
                {
                    if (i == max || j == 1 || j == (2 * i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void Pattern12()
        {
            var num = 8;
            for (var i = -num; i <= num; i++)
            {
                var k = i;
                if (k < 0)
                {
                    k = k * -1;
                }
                for (var j = 0; j <= num; ++j)
                {
                    if (j < k)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void Pattern13()
        {
            int size = 5;

            int z = 1;
            for (int i = 0; i <= size; i++)
            {
                for (int j = size; j > i; j--)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                if (i > 0)
                {
                    for (int k = 1; k <= z; k++)
                    {
                        Console.Write(" ");
                    }
                    z += 2;
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            z -= 4;

            for (int i = 0; i <= size - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int k = 1; k <= z; k++)
                {
                    Console.Write(" ");
                }
                z -= 2;

                if (i != size - 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void Pattern14()
        {
            int size = 5;

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y <= 4 * size; y++)
                {
                    double dist1 = Math.Sqrt(Math.Pow(x - size, 2) + Math.Pow(y - size, 2));
                    double dist2 = Math.Sqrt(Math.Pow(x - size, 2) + Math.Pow(y - 3 * size, 2));

                    if (dist1 < size + 0.5 || dist2 < size + 0.5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            for (int x = 1; x < 2 * size; x++)
            {
                for (int y = 0; y < x; y++)
                    Console.Write(" ");

                for (int y = 0; y < 4 * size + 1 - 2 * x; y++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }

        private static void Heading()
        {
            Console.WriteLine();
            Console.WriteLine(new String('/',50));
            Console.WriteLine("Patter "+ number++);
            Console.WriteLine(new String('/', 50));
            Console.WriteLine();
        }
    }
}
