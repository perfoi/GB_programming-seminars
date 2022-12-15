// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Num = new int[N];
ArrayRandomNumbers(Num);
Console.WriteLine("Вывод массива: ");
PrintArray(Num);
int Sum = 0;
for (int i = 1; i < Num.Length; i+=2)
Sum = Sum + Num[i];
Console.WriteLine($"Сумма элементов на нечётных позициях = {Sum}");
void ArrayRandomNumbers(int[] Num)
{
for(int j = 0; j < Num.Length; j++)
{
Num[j] = new Random().Next(1,10);
}
}
void PrintArray(int[] Num)
{
Console.Write("[ ");
for(int j = 0; j < Num.Length; j++)
{
Console.Write(Num[j] + " ");
}
Console.Write("]");
Console.WriteLine();
}