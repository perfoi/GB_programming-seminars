// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[N, N];
int num = 1;
int row = 0;
int column = 0;
while (num <= N * N)
{
    nums[row, column] = num;
    if (row <= column + 1 && row + column < N - 1)
        ++column;
    else if (row < column && row + column >= N - 1)
        ++row;
    else if (row >= column && row + column > N - 1)
        --column;
    else
        --row;
    ++num;
}
PrintArray(nums);
void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}