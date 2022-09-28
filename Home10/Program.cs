Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int index = 1;

void Cube(int num)
{
    while (index <= n)
    {
        int res = index * index * index;
        Console.WriteLine($" | {index, 5}  |  {res, 5} |");
        index++;
    }
}

if (n > 0) Cube(n);
else Console.WriteLine("Введите корректное знаечение");