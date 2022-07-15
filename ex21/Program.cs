using System;

namespace ex21
{
    class Program
    {
        //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой точки:");
            Console.Write("X: ");
            int firstX = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int firstY = int.Parse(Console.ReadLine());
            Console.Write("Z: ");
            int firstZ = int.Parse(Console.ReadLine());
            Point a = new Point(firstX, firstY, firstZ);

            Console.WriteLine("Введите координаты второй точки:");
            Console.Write("X: ");
            int secondX = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int secondY = int.Parse(Console.ReadLine());
            Console.Write("Z: ");
            int secondZ = int.Parse(Console.ReadLine());
            Point b = new Point(secondX, secondY, secondZ);

            Console.WriteLine("Длина отрезка в 3D координатах равна {0}", GetDistance(a, b));
        }
        static double GetDistance(Point a, Point b) =>  
            Math.Round(Math.Sqrt(((b.X - a.X) * (b.X - a.X)) + ((b.Y - a.Y) * (b.Y - a.Y)) + ((b.Z - a.Z) * (b.Z - a.Z))), 2);
        
    }
}
