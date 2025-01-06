using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class prime_number
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number <= 3)
            {
                return true;
            }

            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main()
        {
            Console.Write("Введите целое число: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} - простое число.");
                }
                else
                {
                    Console.WriteLine($"{number} - не является простым числом.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
            Console.ReadKey();
        }
    }
}
