Console.WriteLine("Введите количество строк матрицы m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] CreateMatrixRndInt(int rows, int columns, int min = 1, int max = 15)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

void МinElemSum(int[,] matrix) 
{
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0, i];
    }
    int minSum = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumRow += matrix[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSum = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой {minSum + 1}, сумма = {minRow}");
}

int [,] array2D = CreateMatrixRndInt(m, n);
PrintMatrix(array2D);
МinElemSum(array2D);

//1 = 42  2 = 58 3 = 47 4 = 51 5 = 43