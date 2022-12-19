// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 
// (можно использовать готовую функцию)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Введите количество строк: ");
int rowsVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rowsVol, columnsVol];
ArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Вывод массива до изменения: ");
PrintArray(numbers);

for (int row = 0; row < numbers.GetLength(0); row++)
{
    for (int column = 0; column < numbers.GetLength(1) - 1; column++)
    {
        for (int i = 0; i < numbers.GetLength(1) - 1; i++)
        {
            if (numbers[row, i] < numbers[row, i + 1])
            {
                int temp = 0;
                temp = numbers[row, i];
                numbers[row, i] = numbers[row, i + 1];
                numbers[row, i + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Вывод массива с упорядоченными значениями: ");
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