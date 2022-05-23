/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
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

string s = "";
int N = 0;
do
{
    Console.Clear();
    Console.WriteLine("Хотите задать размер массива вручную? Нажмите 'y' или 'n'. Для выхода нажмите 'q'.");
    s = Console.ReadLine();
    if (s == "n")
    {
        N = new Random().Next(1, 100);

    }
    else if (s == "y")
    {
        N = InputN(0);
    }
    else if (s == "q") break;

    int[] Array = new int[N];
    Array = FillArray(Array);
    PrintArray(Array);
    Console.ReadKey();

} while (true);