Console.WriteLine("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int Akkerman(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if ((numN == 0) && (numM > 0)) return Akkerman(numM - 1, 1);
    return Akkerman(numM - 1, Akkerman(numM, numN - 1));
}
int result = Akkerman(numberM, numberN);
if(numberM >= 0 && numberN >= 0) 
Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {result}");
else Console.WriteLine("Введите корректное число");