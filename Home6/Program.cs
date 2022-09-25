// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");
int Num = Convert.ToInt32(Console.ReadLine());
string NumText = Convert.ToString(Num);
if (NumText.Length > 2)
{
    Console.WriteLine("3 цифра -> " + NumText[2]);
}
else
{
    Console.WriteLine("-> 3 цифры нет");
}