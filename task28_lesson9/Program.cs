// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
 }
 void PrintSum(int M, int N, int Sum)
 {
    Sum = Sum + N;
    if (N <= M)
    {
        Console.Write($"{Sum} ");
        return;
     }
     PrintSum(M, N - 1, Sum);
 }
 int M = InputNumber("Введите значение M: ");
 int N = InputNumber("Введите значение N: ");
 int i = M;
 if (M > N)
 {
    M = N;
    N = i;
 }
 Console.Write("Сумма натуральных элементов в промежутке от M до N = ");
 PrintSum(M, N, i = 0);
