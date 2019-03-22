using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3
{
    class Program
    {
        static int max(int a, int b)
        {
            int c = a + b;
            return (c);

        }

        static int min(int a, int b)
        {
            int c = a - b;
            return (c);

        }

        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter B: ");
            int b = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
