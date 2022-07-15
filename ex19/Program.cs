﻿using System;

namespace ex19
{
    class Program
    {
        //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        static void Main(string[] args)
        {
            Console.Write("Введите пятизначное положительное число: ");
            string n = Console.ReadLine();
            while (true)
            {
                if (!string.IsNullOrEmpty(n) && n.Length == 5 && n[0] != '-' && int.TryParse(n, out int num)) break;
                
                Console.WriteLine("Неверный ввод!");
                Console.Write("Введите пятизначное положительное число: ");
                n = Console.ReadLine();
            }

            Console.WriteLine(IsPalindrome(n) ? $"{n} -> Палиндром" : $"{n} -> Не палиндром");
        }


        static bool IsPalindrome(string num)
        {
            int i = 0;
            while (i < num.Length / 2)
            {
                if (num[i] != num[num.Length - i - 1])
                {
                    return false;
                }
                i++;
            }
            return true;
        }

    }
}
