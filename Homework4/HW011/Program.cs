/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Является ли палиндоромом число: ");

int value = 12321;
Console.WriteLine(value);

if(value/10_000 > 0 && value/10_000 < 10)
{
    int[] array = ValToArr(value);
    string mass1 = PrintArr(array);

    int[] rev = array;
    ArrReverse(rev);
    string mass2 = PrintRev(rev);

    if (mass1 == mass2)
    {
        Console.WriteLine("Является");
    }
    else
    {
        Console.WriteLine("Не является");
    }
}
else
{
    Console.WriteLine("Задано неверное число");
}



static string PrintRev(int[] rev)
{
    string mass2 = String.Empty;
    for (int i = 0; i < rev.Length; i++)
    {
        mass2 = mass2 + Convert.ToString(rev[i]) + " ";
    }
    Console.WriteLine(mass2);
    return mass2;
}

static string PrintArr(int[] array)
{
    string mass1 = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        mass1 = mass1 + Convert.ToString(array[i]) + " ";
    }
    Console.WriteLine(mass1);
    return mass1;
}

static void ArrReverse(int[] rev)
{
    for (int i = 0, j = rev.Length - 1; i < j; i++, j--)
    {
        int temp = rev[i];
        rev[i] = rev[j];
        rev[j] = temp;
    }
}

int[] ValToArr(int value)
{
    string str = value.ToString();
    int[] array = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        array[i] = int.Parse(str[i].ToString());
    }
    return array;
}

