Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int Sum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int arg = num % 10;
        num = (num - arg) / 10;
        sum = sum + arg;
    }
    return sum;
}
if (number >= 0)
{
    int res = Sum(number);
    Console.WriteLine($"{number} -> {res}");
}
else Console.WriteLine("Не корректное число");