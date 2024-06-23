
using System;

namespace Task_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // في اسواء الاحوال راح نمشي ل       o(n)
            int product(int a, int b)
            {
                int sum = 0;
                for (int I = 0; I < b; I++)
                {
                    sum += a;
                }
                return sum;
            }

            //1.2  O(n)
            static int power(int a, int b)
            {
                if (b < 0) return a;
                if (b == 0) return 1;
                int sum = a;
                for (int I = 0; I < b - 1; I++)
                {
                    sum *= a;
                }
                return sum;
            }

            //1.3  O(N)   O(1)

            int mod(int a, int b)
            {
                if (b <= a) return -1;
                int div = a / b;
                return a - div * b;
            }
            // 1.4       O(N)

            int div(int a, int b)
            {
                int count = a;
                int sum = b;
                while (sum <= a)
                {
                    sum += b;
                    count++;
                }
                return count;
            }

            //Q 1.5        O(n)
            //Q 1.6       O(sqrt(n))
            // Q 1.9   O(N^2), where N is the length of the input array
        }
    }
}
