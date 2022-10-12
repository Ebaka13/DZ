int[] CreateArrayPolso(int size, int min, int max)

{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

    int[] SumPositiveNum(int[] array)
{
    int sumPosNum = default;


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPosNum++;
    }

    return new int[] { sumPosNum };
}

int[] arr = CreateArrayPolso(15, -15, 13);
PrintArray(arr);
int[] sumPositiveNum = SumPositiveNum(arr);
PrintArray(sumPositiveNum);
