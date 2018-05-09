using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_metody_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число n");
            string x = Console.ReadLine();
            double n = Convert.ToDouble(x);

            if (n > 0)
            {
                Console.WriteLine("Введённое число является положительным");
            }
            else
            {
                Console.WriteLine("Введённое число является отрицательным. Конец программы");
                Console.ReadKey();
                Environment.Exit(0);
            }

            if (n > 1 && n % 1 == 0)
            {
                Console.WriteLine("Введённое число является натуральным, т.е. целым и положительным");
            }
            else
            {
                Console.WriteLine("Введённое число либо лежит в интервале от 0 до 1, либо оно нецелое. Конец программы");
                Console.ReadKey();
                Environment.Exit(0);
            }

            bool prost = true;
            for (int i=2; i<=Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }

            if (prost)
            {
                Console.WriteLine("Введённое число простое");
            }
            else
            {
                Console.WriteLine("Введённое число не простое");
            }

            Console.WriteLine("Проверка деления введённого числа без остатка на 2,3,5,6 и 9");
            int[] array = new int[5] { 2, 3, 5, 6, 9 };
            for (int i=0; i<array.Length; i++)
            {
                if (n % array [i] == 0)
                {
                    Console.WriteLine("Введённое число делится без остатка на " + array[i]);
                }
                else
                {
                    Console.WriteLine("Введённое число не делится без остатка на " + array[i]);
                }

            }
            Console.ReadKey();
        }
    }
}
