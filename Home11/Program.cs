Console.WriteLine("Введите число A: ");
int a =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int Degree(int numA, int numB)
{
    int sum = 1;
    for(int i = 1; i <= numB; i++)
    {
        sum = sum * numA;
    }
    return sum;
}
if (b != 0)
{
    int result = Degree(a, b);
    Console.WriteLine($"{a} ^ {b} = {result}");
}
else 
Console.WriteLine($"{a} ^ {b} = 1");
