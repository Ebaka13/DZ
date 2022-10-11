int[] CreateArrayRndInt(int size, int min, int max)

{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 1; i < size; i++)
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
int[] GetSumOddIndex(int[] array)
{
    int sumOddIndex = 0;

    for (int i = 1; i < array.Length; i = i + 2)
    {

        if (i < array.Length)
            sumOddIndex = sumOddIndex + array[i];
        else i = i + 2;
    }
    return new int[] { sumOddIndex };

}

int[] arr = CreateArrayRndInt(5, 10, 50);
PrintArray(arr);
int[] sumOddIndex = GetSumOddIndex(arr);
Console.WriteLine($"Сумма элементов, на нечётных позициях = {sumOddIndex[0]}");