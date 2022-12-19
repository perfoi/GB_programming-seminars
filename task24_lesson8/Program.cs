// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
// (можно использовать готовую функцию)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Задайте размер прямоугольного двумерного массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[N, N];
ArrayRandomNumbers(numbers);
PrintArray(numbers);
int minSum = Int32.MaxValue;
int i = 0;

for (int row = 0; row < numbers.GetLength(0); row++)
{
    int sum = 0;
    for (int column = 0; column < numbers.GetLength(1); column++)
    {
        sum = sum + numbers[row, column];        
    }
    if (sum < minSum)
    {
        minSum = sum;
        i++;
    }
}

Console.WriteLine($"Строка с наименьшей суммой елементов: {i}");
Console.WriteLine($"Сумма елементов = {minSum}");

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