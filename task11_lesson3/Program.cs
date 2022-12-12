// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
void Cb(int[] N)
{
    int count = 0;
    int length = N.Length;
    while (count <  length)
{
    N[count] = Convert.ToInt32(Math.Pow(count, 3));
    count++;
}
}
void PrintArr (int[] c)
{
    int count = c.Length;
    int i = 0;
    while(i < count)
{
    Console.Write(c[i]+ " ");
    i++;
}
} 
int[] TabCube = new int[N + 1];
Cb(TabCube);
PrintArr (TabCube);