Console.WriteLine("Введите позицию элемента в строке ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элеманта в столбце ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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
bool ReturnElem(int[,] matrix, int rows, int columns)
{
    return rows < matrix.GetLength(0) && columns < matrix.GetLength(1);
}
int[,] array2D = CreateMatrixRndInt(5, 6, -10, 10);
PrintMatrix(array2D);
if (ReturnElem(array2D, rows, columns))
    Console.WriteLine(array2D[rows, columns]);
else Console.WriteLine($"{rows},{columns} -> Такой элемент отсутствует");