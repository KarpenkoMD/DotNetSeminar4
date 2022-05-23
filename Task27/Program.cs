/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int NumberSum(int number)
{
    int Sum = 0;
    while (number != 0)
    {
        Sum = Sum + number % 10;
        number = number / 10;
    }
    return Sum;
}

int NumberToInput = 0;

Console.Clear();
Console.Write("Введите число: ");
NumberToInput = Convert.ToInt32(Console.ReadLine());

int result = NumberSum(NumberToInput);

Console.WriteLine();
Console.WriteLine($"Сумма цифр числа {NumberToInput} равна = {result}.");