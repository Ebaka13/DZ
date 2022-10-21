Console.WriteLine("Введите количество строк в 1 матрице");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в 1 матрице");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк во 2 матрице");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов во 2 матрице");
int b = Convert.ToInt32(Console.ReadLine());
int[,] CreateMatrixFirst(int rows, int columns, int min = 1, int max = 15)
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

int[,] CreateMatrixSecond(int rows, int columns, int min = 1, int max = 15)
{
    int[,] matrix2 = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix2;
}

void PrintMatrixSecond(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (j < matrix2.GetLength(1) - 1) Console.Write($"{matrix2[i, j],4}, ");
            else Console.Write($"{matrix2[i, j],4}");
        }
        Console.WriteLine("]");
    }
}


int[,] ProizMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix2.GetLength(0); ++j)
            for (int a = 0; a < matrix2.GetLength(1); ++a)
                resultMatrix[i, a] += matrix[i, j] * matrix2[j, a];
    return resultMatrix;
}
void PrintProizMatrix(int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            if (j < resultMatrix.GetLength(1) - 1) Console.Write($"{resultMatrix[i, j],4}, ");
            else Console.Write($"{resultMatrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixFirst(m, n);
PrintMatrix(array2D);
Console.WriteLine();
int[,] arr2D = CreateMatrixSecond(a, b);
PrintMatrixSecond(arr2D);
Console.WriteLine();
int[,] resultMatrix = ProizMatrix(array2D, arr2D);
PrintProizMatrix(resultMatrix);
