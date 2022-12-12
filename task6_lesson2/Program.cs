// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine ("Введи число: ");
int N = Convert.ToInt32(Console.ReadLine());
string NN = Convert.ToString(N);
if (NN.Length > 2)
    Console.WriteLine("Третья цифра: " + NN[2]);
else
    Console.WriteLine("Третьей цифры нет");