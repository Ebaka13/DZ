// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введи трёхзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
string stringNum = Convert.ToString(Num);
Console.WriteLine("2 цифра -> "+stringNum[1]);