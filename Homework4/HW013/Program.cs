/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите значение числа N: ");
int n = Convert.ToInt32(Console.ReadLine());

CubeOfN(n);

void CubeOfN(int n)
{
    for (int i = 0; i < n + 1; i++)
    {
        double cube = Math.Pow(i, 3);
        Console.Write(cube + " ");
    }
}
