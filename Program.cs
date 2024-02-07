void PrintConsecutiveNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{m} ");
        m++;
        PrintConsecutiveNumbers(m, n);
    }
}

long Akkerman(int m, long n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

void PrintReverseArray(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        PrintReverseArray(array, i + 1);
        Console.Write($"{array[i]}\t");
    }
}

Console.Clear();
Console.WriteLine("Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные" +
"числа в промежутке от M до N.\nИспользовать рекурсию, не использовать циклы.");
int m = 5, n = 40;
Console.WriteLine($"m = {m}, n = {n}.");
PrintConsecutiveNumbers(m, n);
Console.WriteLine();
Console.WriteLine("Нажмите любую кнопку...");
Console.ReadLine();

Console.Clear();
Console.WriteLine("Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.\n" +
"Даны два неотрицательных числа m и n.");
m = 3;
n = 7;
Console.WriteLine($"ak({m},{n}) = {Akkerman(m, n)}.");
Console.ReadLine();

Console.Clear();
Console.WriteLine("Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.\n" +
"Использовать рекурсию, не использовать циклы.");
int[] array = { 1, 5, 3, -5, 8, 15, -45, 24, 0 };
int k = array.Length - 1;
PrintReverseArray(array);