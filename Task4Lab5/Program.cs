using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            bool f = false;
            int sum = 0;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 1; i < n; i+=2)
            {
                if (array[i] % 2 != 0 && array[i] > 0)
                {                    
                    Console.Write("{0} ",array[i]);
                    sum += array[i];
                    f = true;
                }
            }
            if (!f)
            {
                Console.WriteLine("Элеменетов нет");
            }
            Console.WriteLine();
            Console.WriteLine("Сумма нечетных положительных чисел на четных местах в массиве = {0}", sum);
            Console.ReadKey();
        }
    }
}
