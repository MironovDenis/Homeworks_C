/* 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/* int n = new Random().Next(1, 10);
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1, 10);
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}*/ 

int n = new Random().Next(1, 30);
Console.WriteLine($"Массив будет состоять из {n} чисел");
int[] NewArray()
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

string ArrayOut(int[] array)
{
    string str = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        str = str + Convert.ToString(array[i]) + ", ";
    }
    return str;
}

int[] arr = NewArray();
string str = ArrayOut(arr);

Console.Write("[" + str + "]");