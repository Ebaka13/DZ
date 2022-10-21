Console.WriteLine("введите количество строк матрицы: m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов матрицы: n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] CreateMatrix(int rows, int columns, int min=-10, int max=15)
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

void PrMatrix(int[,] matrix)
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
void MaxMinElem(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int a = 0; a < matrix.GetLength(1) - 1; a++)
            {
                if (matrix[i, a] < matrix[i, a + 1])
                {
                    int temp = 0;
                    temp = matrix[i, a];
                    matrix[i, a] = matrix[i, a + 1];
                    matrix[i, a + 1] = temp;
                }
            }
        }
    }
}

int [,] array2D = CreateMatrix(m,n);
PrMatrix(array2D);
Console.WriteLine();
MaxMinElem(array2D);
PrMatrix(array2D);