using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("vuvedi simvolche=");
            var b = Console.ReadLine();
            for (int i = 1; i <= n; i++)
            {
                Console.Write(b);
                for (int j = 1; j < i; j++)
                    Console.Write(b);
                Console.WriteLine();
            }
        }
    }
}
