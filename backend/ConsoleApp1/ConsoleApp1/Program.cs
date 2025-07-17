using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                if (n1 > n3)
                    Console.WriteLine(n1);
                else
                    Console.WriteLine(n3);
            }
            else
            {
                if (n2 > n3)
                    Console.WriteLine(n2);
                else
                    Console.WriteLine(n3);
            }
            Console.ReadLine();
        }
    }
}
