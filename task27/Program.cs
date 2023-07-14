// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int limit)
{
    int summa = 0;
    int count = limit;
    while (limit > 0)
    {
        summa = summa + limit % 10;
        limit /= 10;
    }
    Console.WriteLine($"Сумма чисел в числе {count} составляет {summa}");
    return summa;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int limit = GetInput("Введите число:");
GetSum(limit);
