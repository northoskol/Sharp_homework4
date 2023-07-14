// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// ****Решение изначальное******

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1, 99);
    }
}

int[] array = new int[8];
FillArray(array);

Random random = new Random();                                     //
string firstRow = string.Join(", ", array.Take(5));               //берет первые 5 чисел для первой строки
string secondRow = string.Join(", ", array.Skip(5).Take(3));      //пропускает первые 5 чисел и берет следующие 3 числа для второй строки
Console.WriteLine("Массив из 8 элементов сегодня такой:");
// Console.WriteLine($"[{String.Join(",", array)}]");             //вывод в одну строку
Console.WriteLine($"[{firstRow}]");
Console.WriteLine($"[{secondRow}]");
//___________________________________________________________________

// Вариант из условия

// int[] array = { 1, 2, 5, 7, 19, 6, 1, 33 };

// string firstRow = string.Join(", ", array.Take(5));
// string secondRow = string.Join(", ", array.Skip(5).Take(3));

// Console.WriteLine("Массив из 8 элементов сегодня такой:");
// Console.WriteLine($"[{firstRow}]");
// Console.WriteLine($"[{secondRow}]");

//___________________________________________________________________

//Решение из подсказки.

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string ReadInput = System.Console.ReadLine();
//     int result = int.Parse(ReadInput);
//     return result;
// }

// int[] GenerateArray(int Length, int minValue, int maxValue)
// {
//     int[] array = new int[Length];
//     Random random = new Random();
//     for (int i=0; i<Length; i++)
//     {
//         array[i]=random.Next(minValue,maxValue+1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     System.Console.Write("[");
//     for (int i=0; i<array.Length-1; i++)
//     {
//         System.Console.Write($"{array[i]}, ");
//     }
//     System.Console.Write($"{array[array.Length-1]}");
//     System.Console.WriteLine("]");
// }

// int length=Prompt("Длина масива: ");
// int min=Prompt("Начальное значение, для диапазона случайного числа: ");
// int max=Prompt("Конечное значение, для диапазона случайного числа: ");
// int[] array=GenerateArray(length,min,max);
// PrintArray(array);