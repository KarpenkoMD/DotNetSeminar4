/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
int InputN(int border)
{
    int NumberToInput = 0;
    do
    {
        Console.Write($"Введите число больше {border}: ");
        NumberToInput = Convert.ToInt32(Console.ReadLine());
        if (NumberToInput <= border)
        {
            Console.Write("Ошибка!");
            Console.ReadKey();
            Console.Clear();
        }

        else
        {
            return NumberToInput;
        }
    } while (true);
}

int[] FillArray(int[] ArrayToFill)
{
    for (int i = 0; i< ArrayToFill.Length; i++)
    {
        ArrayToFill[i] = new Random().Next(1, 1000);
    }
    return ArrayToFill;
}

void PrintArray(int[] ArrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < ArrayToPrint.Length; i++)
    {
        Console.Write($"{ArrayToPrint[i]}");
        if (i < ArrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

string SimbolToCheck = "";
int ArraySize = 0;
do
{
    Console.Clear();
    Console.WriteLine("Хотите задать размер массива вручную? Нажмите 'y' или 'n'. Для выхода нажмите 'q'.");
    SimbolToCheck = Console.ReadLine();
    if (SimbolToCheck == "n")
    {
        ArraySize = new Random().Next(1, 100);

    }
    else if (SimbolToCheck == "y")
    {
        ArraySize = InputN(0);
    }
    else if (SimbolToCheck == "q") break;

    int[] Array = new int[ArraySize];
    Array = FillArray(Array);
    PrintArray(Array);
    Console.ReadKey();

} while (true);