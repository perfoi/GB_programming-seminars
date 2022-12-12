// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите исходное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int NN = Convert.ToString(N).Length;
int res = 0;
int intRes = 0;
int SUM(int N)
{
for (int i = 0; i < NN; i++)
{
intRes = N - N % 10;
res = res + (N - intRes);
N = N / 10;
}
return res;
}
int sum = SUM(N);
Console.WriteLine($"Сумма цифр исходного числа: {sum}");