using System;

namespace vs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write in C# expressions
            int a = 2, b = 3, x = 2, y = 3, z = 5, i = 6, j = 0, k = 9, area = 34, n = 4;


            // x^2 + 3x -4
            Console.WriteLine(x * x + 3 * x - 4);

            // (x+y)z
            Console.WriteLine((x + y) * z);

            // x + 3y / 2x-y
            Console.WriteLine((x + 3 * y) / (2 * x - y));

            // 1 / x^2+x+3
            Console.WriteLine((1 / (x * x + x + 3)));

            //x+y/7
            Console.WriteLine((x + y) / 7);

            //2xy^3
            Console.WriteLine(2 * x * y * y * y);

            //x=3y/7-z
            Console.WriteLine((3 * y) / (7 - z));

            //z = area (sqrt(area))
            Console.WriteLine(area * Math.Sqrt(area));

            //x+32 / y-32 - x-2y
            Console.WriteLine((x + 32) / (y - 32) - x - 2 * y);

            //res = 3ijk + k^9 / 7ik - 5(sqrt(j+k))
            Console.WriteLine(3 * i * j * k + Math.Pow(k, 9) / 7 * i * k - 5 * (Math.Sqrt(j + k)));



            Console.WriteLine((1 + 8 / 2 + (1 * 4) + (5 * 4)) / 4);
            Console.WriteLine((1 + 1 + 1 + 1 / 2 + (1 + 1 + 1) / 3));
            Console.WriteLine(((3 + 4) + (4 * 7)) / 5);
            Console.WriteLine(5 * 5 + 5 / 5 + 6);
            Console.WriteLine((3 * 6 * 7 * 2) + 12 / 2);
            Console.WriteLine((8 * 4 * 2 + 6) / 2 + 4);

            // 1
            x = 20; y = 35;
            x = y++ + x++;
            y = ++y + ++x;
            Console.WriteLine(x + " " + y);
            // 2
            x = 10; y = 15;
            x = x++;
            y = ++y;
            Console.WriteLine(x + " " + y);
            // 3
            a = 20;
            x = a++;
            Console.WriteLine(x);
            a = a + 3;
            Console.WriteLine(a);
            a -= 5;
            a++;
            Console.WriteLine(a);
            // 4
            n = 4;
            Console.WriteLine(i + j + k - k % n);

            a = 3; b = 4;
            ++a;
            a *= b++;
            Console.WriteLine(a);

            a = 3; b = 4;
            ++a;
            a *= ++b;
            Console.WriteLine(a);


            int c = 5;

            // 1
            Console.WriteLine(++a);
            // 2
            Console.WriteLine(a++);
            // 3
            Console.WriteLine(b += a);
            // 4
            Console.WriteLine(b += a);
            // 5
            Console.WriteLine(a++ + b++);
            // 6
            n = 22 / 7;
            Console.WriteLine(n);
            // 7
            double A = 4, B = 3, P = 8, Q = 2;
            double N = Q / A - P / B;
            Console.WriteLine(N);
            // 8
            N = 0;
            N = P / B - Q / A;
            Console.WriteLine(n);
            // 9
            N = 0;
            N = Q * P + 3.0 * P * P - (Q % 3) * P * P * P;
            Console.WriteLine(N);
            // 10
            N = 0;
            N = (Q % 2) * P + 6.0 * P * (Q % 3) + (Q % 4) * P * P * P;
            Console.WriteLine(N);

            /* Compute the following arithmetic expressions
            1 - (a+b /(c-5))/((d+7)/(e-37)%3)
            2 - a+b / c - 5 / d + 7 / e - 37 % 3
            3 - a*(b*b) - (c*b) + d     */
            // 1
            a = 10; b = 20; c = 15; int d = 8, e = 40;
            Console.WriteLine((a + b / (c - 5)) / ((d + 7) / (e - 37) % 3));
            // 2
            Console.WriteLine(a + b / c - 5 / d + 7 / e - 37 % 3);
            // 3
            Console.WriteLine(a * (b * b) - (c * b) + d);

        }
    }
}