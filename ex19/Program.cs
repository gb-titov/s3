using System;

namespace ex19
{
    class Program
    {
        //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        static void Main(string[] args)
        {
            string n = GetString();
            Console.WriteLine(IsPalindrome(n) ? $"Через строки: {n} -> Палиндром" : $"Через строки: {n} -> Не палиндром");
            Console.WriteLine(IsPalindrome(Convert.ToInt32(n)) ? $"Через число: {n} -> Палиндром" : $"Через число: {n} -> Не палиндром");
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

        static bool IsPalindrome(int num)
        {
            int reverseNum = 0, tempNum = num;

            while (tempNum > 0)
            {
                reverseNum = reverseNum * 10 + tempNum % 10;
                tempNum = tempNum / 10;
            }

            return reverseNum == num;
        }

        static string GetString()
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

            return n;
        }
    }
}
