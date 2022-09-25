// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи цифру: ");
int day = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int day) {
  if (day == 6 || day == 7) {
  Console.WriteLine("Выходной ? -> да");
  }
  else if (day < 1 || day > 7) {
    Console.WriteLine("Не день недели");
  }
  else Console.WriteLine("Выходной ? -> нет");
}

CheckingTheDayOfTheWeek(day);
