//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
string NN = Convert.ToString(N);{
    if (NN.Length == 5)
    Console.WriteLine("Введено пятизначное число");
    else Console.WriteLine("Введите корректное число");
    }
    if (NN[0]==NN[4] || NN[1]==NN[3]){
    Console.WriteLine("Является палиндромом");
    }
    else Console.WriteLine("Не является палиндромом");