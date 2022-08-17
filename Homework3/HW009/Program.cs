/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 
*/



int value = new Random().Next(1, 100_000);
Console.WriteLine("Берется число: " + value);

static int NewMethod(int value)
{
    int sum = 0;
    /*while (value != 0)
    {
        sum += value % 10;
        value /= 10;
    }*/
    for (int i = value; i != 0; i/=10)
    {
        sum += i % 10;
    }
    return sum;
}
Console.WriteLine($"Сумма цифр в числе равна: {NewMethod(value)}");
