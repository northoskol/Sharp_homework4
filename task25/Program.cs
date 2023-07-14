// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void GetDegree(int num1, int num2)
{
    int temp = num1;
    for (int i = 1; i < num2; i++)
    {
        temp = temp*num1;
    }
    Console.WriteLine($"{num1}, {num2} -> {temp}");
}


int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int numberA = GetInput("Введите число A: ");
int numberB = GetInput("Введите число B: ");
GetDegree(numberA, numberB);