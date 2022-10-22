Console.WriteLine("Введите первое число: ");
int numF = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numS = Convert.ToInt32(Console.ReadLine());
int Sum(int numF, int numS)
{
    if (numF < numS) return numS + Sum(numF, numS - 1);
    if (numF > numS) return numS + Sum(numF, numS + 1);
    return numF;
}
int result = Sum(numF, numS);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numF} до {numS} -> {result}");