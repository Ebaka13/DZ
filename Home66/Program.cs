Console.WriteLine("Введите первое число: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numN = Convert.ToInt32(Console.ReadLine());
int Sum(int numM, int numN)
{
    if (numM < numN) return numN + Sum(numM, numN - 1);
    if (numM > numN) return numN + Sum(numM, numN + 1);
    return numM;
}
int result = Sum(numM, numN);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numM} до {numN} -> {result}");