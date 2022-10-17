Console.WriteLine("введите количество строк матрицы: m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов матрицы: n");
int n = Convert.ToInt32(Console.ReadLine());
double[,] CreateMatrixIndex(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)   
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble()*10), 1, MidpointRounding.ToZero);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[  ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" ]");
    }
}
double[,] arrayInd = CreateMatrixIndex(m, n);
PrintMatrix(arrayInd);