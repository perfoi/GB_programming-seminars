// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// (т.е нужно решить задачу без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A:"); //основание
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:"); //степень
int B = Convert.ToInt32(Console.ReadLine());
int res = 1;
for (int i = 1; i <= B; i++)
res = res * A;
Console.WriteLine ($"Результат возведения числа {A} в степень {B}: {res}");