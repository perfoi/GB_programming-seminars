// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, 
// и возвращает индекс этого элемента или же указание, что такого элемента нет. 
// Если элементов несколько, то выводим позицию каждого. Двумерный массив задаётся на ваш выбор.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
ArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine($"Значение искомого элемента = {numbers[n-1,m-1]} ");
    Console.WriteLine($"Номер строки {n} ");
    Console.WriteLine($"Номер столбца {m} ");
}

PrintArray(numbers);

void ArrayRandomNumbers(int[,] inArray)
{
    for (int row = 0; row < inArray.GetLength(0); row++)
        {        
            for (int column = 0; column < inArray.GetLength(1); column++)
            {
                inArray [row,column] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] inArray)
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            Console.Write($"{inArray[row,column]} ");
        }   
        Console.WriteLine(); 
    }
}