﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int Akkerman(int M, int N)
{
    if (M == 0)
{
    return N + 1;
}
else if (N == 0 && M > 0)
{
    return Akkerman(M - 1, 1);
}
else
{
    return Akkerman(M - 1, Akkerman(M, N - 1));
}
}
int M = InputNumber("Введите значение M: ");
int N = InputNumber("Введите значение N: ");
int akkermanFunction = Akkerman(M, N);
Console.Write($"Результат вычисления функции Аккермана: A(m,n) = {akkermanFunction} ");