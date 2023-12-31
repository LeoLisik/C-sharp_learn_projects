using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double E, sum = 0, s, f;
            float k;
            do
            {
                Console.WriteLine("Введите n");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1);
            for (k = 1; k <= n; k++)
            {
                f = k / ((k + 1) * (k + 2));
                sum = sum + f;
            }
            Console.WriteLine($"Сумма первых n членов = {sum}");
            do
            {
                Console.WriteLine("Введите E");
                E = Convert.ToDouble(Console.ReadLine());
            } while (E >= 1);
            for (double d = 1; true; d++)
            {
                s = d / ((d + 1) * (d + 2));
                if (Math.Abs(s) >= E)
                {
                    Console.WriteLine($"A{d} = {s}");
                }
            }
        }
    }
}
