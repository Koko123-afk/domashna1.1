using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 1;
            int s = 2;
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            if (n >= 3 && n <= 102)
            {
                while (s <= n)
                {
                    N = N + s;
                    s++;
                }
                Console.WriteLine(N);
            }
        }
    }
}
