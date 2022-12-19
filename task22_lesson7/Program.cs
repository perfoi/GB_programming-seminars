// Задача 52. Задайте двумерный массив (вручную) из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];
ArrayRandomNumbers(numbers);

for (int column = 0; column < numbers.GetLength(1); column++)
{
    double avarage = 0;
    for (int row = 0; row < numbers.GetLength(0); row++)
    {
        avarage = (avarage + numbers[row, column]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);

void ArrayRandomNumbers(int[,] inArray)
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            inArray[row, column] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] inArray)
{

    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            Console.Write(inArray[row, column] + " ");
        }
        Console.WriteLine();
    }
}