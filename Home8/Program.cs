Console.Write("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());


bool comparison(int num)
{
    int firstDigit = numbers / 10000 % 10;
    int secondDigit = numbers / 1000 % 10;
    int fourthDigit = numbers / 10 % 10;
    int fifthDigit = numbers % 10;
    return firstDigit == fifthDigit && secondDigit == fourthDigit;


}
if (numbers < 10000 || numbers > 99999) Console.WriteLine("Не пятизначное");
else
{
    if (comparison(numbers)) Console.Write($"{numbers} -> Палиндром");
    else Console.Write($"{numbers} -> Не палиндром");
}

