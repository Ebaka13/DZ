double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1, MidpointRounding.ToZero);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DiffMaxMinNum(double[] array)
{
    double diff = default;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)  max = array[i]; 
        if(array[i] < min) min = array[i];

        diff = max - min; 
    }
    
    return diff;
}

double[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
double diffMaxMinNum = DiffMaxMinNum(arr);
Console.WriteLine(Math.Round(diffMaxMinNum, 1, MidpointRounding.ToZero));
