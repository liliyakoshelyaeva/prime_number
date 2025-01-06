using System;


namespace prime_number
{
    internal class prime_number
    {
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                { return false; }
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
