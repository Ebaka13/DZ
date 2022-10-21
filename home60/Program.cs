int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(10, 100);
                int t = matrix[i, j, k];
                int w = 0;
                if (w == t) break;
                if (w != t) t = w;
            }
        }
    }

    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k],4}, ");
                else if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k],4}, ");
                else Console.Write($"{matrix[i, j, k],4}");
            }
        }
        Console.WriteLine("]");
    }
}

void IndexsElement(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write($"{arr3D[i, j, k]} ({i},{j},{k}); ");
            }
        }
    }
}

int[,,] array3D = CreateMatrixRndInt(3, 3, 1, 1, 5);
PrintMatrix(array3D);
IndexsElement(array3D);
