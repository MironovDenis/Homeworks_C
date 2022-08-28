/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] CreateArray(int m)
{
    return new int[m];
}

void FillArray(int[] array)
{
    //int n = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значение {i} элемента массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}

void PrintArray(int[] array)
{
    string print = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        print = print + Convert.ToString(array[i]) + " | ";        
    }
    Console.WriteLine(print);
    Console.WriteLine();
}

void CountPositive(int[] array)
{
    int positive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) positive += 1;
    }
    Console.Write($"Количество чисел в массиве больше 0: {positive}");
}

int[] mass = CreateArray(5);
FillArray(mass);
PrintArray(mass);
CountPositive(mass);