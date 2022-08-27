/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Write("Массив состоит из N элементов. Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] NewArray()
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

string PrintArray(int[] array)
{
    string printarr = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        printarr = printarr + Convert.ToString(array[i]) + " ";
    }
    Console.WriteLine(printarr);
    Console.WriteLine();
    return printarr;
}

int Result(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result += 1;
        }
    }
    Console.WriteLine($"Количество четных элеметов в массиве: {result}");
    return result;
}

int[] arr = NewArray();
PrintArray(arr);
Result(arr);

