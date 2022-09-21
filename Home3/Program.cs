// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 0)
if(num % 2 > 0 ) Console.WriteLine($"{num} не является чётным");
else 
Console.WriteLine($"{num} является чётным");

if(num < 0)
if(-num % 2 > 0) Console.WriteLine($"{num} не является чётным");
else 
Console.WriteLine($"{num} является чётным");