using System;

namespace ex23
{
    class Program
    {
        //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        static void Main(string[] args)
        {
            Console.Write("Введите положительное число: ");
            int n =  Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Введено неверное число.");
                return;
            }

            int i = 1;
            int[] ar = new int[n];


            while (i <= n)
            {
                ar[i - 1] = (int)Math.Pow(i, 3);
                i++;
            }

            Console.WriteLine($"{n} -> {string.Join(", ", Array.ConvertAll<int, string>(ar, Convert.ToString))}");

        }
    }
}
