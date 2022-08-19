/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Console.Write("Введите координаты x1 точки А: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y1 точки А: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z1 точки А: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2 точки B: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2 точки B: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z2 точки А: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double dist = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
dist = Math.Round(dist, 2);

Console.WriteLine($"Расстояние между точками А и В в трехмерном пространстве: {dist}");