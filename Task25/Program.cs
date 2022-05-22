/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

double PowN(int A, int B)
{
    double result = A;

    for (int i = 2; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}
int InputN(int border)
{
    int N = 0;
    do
    {
        Console.Write($"Введите число больше {border}: ");
        N = Convert.ToInt32(Console.ReadLine());
        if (N <= border)
        {
            Console.Write("Ошибка!");
            Console.ReadKey();
            Console.Clear();
        }

        else
        {
            return N;
        }
    } while (true);
}

int NumberA = -1;
int NumberB = -1;


Console.Write("Введите любое число: ");
NumberA = Convert.ToInt32(Console.ReadLine());
NumberB = InputN(0);
double result = PowN(NumberA, NumberB);

Console.WriteLine($"{NumberA} в натуральной степени {NumberB} = {result}.");

