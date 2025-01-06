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
            IsPrime(7);
        }
    }

}
