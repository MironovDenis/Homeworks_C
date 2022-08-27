/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();
int n = 10;

double[] NewArray()
{
    double[] array = new double[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100, 0);
    }
    return array;
}

string PrintArray(double[] array)
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

double MaxElement(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    Console.WriteLine($"Максимальный элемент массива: {max}");
    return max;
}

double MinElement(double[] array)
{
    double min = 1000;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Минимальный элемент массива: {min}");
    return min;
}

double[] arr = NewArray();
PrintArray(arr);
double summinmax = MaxElement(arr) + MinElement(arr);
Console.WriteLine($"Сумма максимального и иинимального элементов массива: {summinmax}");