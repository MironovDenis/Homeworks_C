/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write("Массив состоит из N элементов. Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] NewArray()
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-10, 10);
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

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            sum += array[i];
        }
    }
    Console.WriteLine($"Сумма нечетных элементов массива = {sum}");
    return sum;
}

int[] arr = NewArray();
PrintArray(arr);
Sum(arr);