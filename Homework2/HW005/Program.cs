/* Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int n = new Random().Next(100, 1000);
Console.WriteLine(n);
int a = n / 100;
int b = n % 10;
int result = (n - a*100 - b) / 10;
Console.WriteLine(result);