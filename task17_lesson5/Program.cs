// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 69.4 -22 0.4 78] ->100
// Диапазон любой, ввод зависит от пользователя. (размер, значения)


Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] Num = new double[N];
ArrayRandomNumbers(Num);
Console.WriteLine("Вывод массива: ");
PrintArray(Num);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < Num.Length; i++)
{
if (Num[i] > max)
{
max = Num[i];
}
if (Num[i] < min)
{
min = Num[i];
}
}
Console.WriteLine($"В массиве {Num.Length} элементов ");
Console.WriteLine($"Максимальное значение = {max} ");
Console.WriteLine($"Минимальное значение = {min} ");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");
void ArrayRandomNumbers(double[] numbers)
{
for(int j = 0; j < numbers.Length; j++)
{
numbers[j] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
}
}
void PrintArray(double[] Num)
{
Console.Write("[ ");
for(int j = 0; j < Num.Length; j++)
{
Console.Write(Num[j] + " ");
}
Console.Write("]");
Console.WriteLine();
}