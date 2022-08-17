/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// не понял, зачем нужно писать цикл.

int a = new Random().Next(1, 11);
int b = new Random().Next(1, 11);
Console.WriteLine(a);
Console.WriteLine(b);

double result = Math.Pow(a, b);
Console.WriteLine(result);