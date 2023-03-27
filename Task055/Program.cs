// Задача 55.Задайте двухмерный массив. Напишите программу
// которая заменяет строки на столбцы. В случае если это невозможно,
// программа должна вывести сообщение для пользователя.

int[,] CreateMatrixRndInt(int raws, int columns, int min, int max)
{
    int[,] matrix = new int[raws, columns];

    Random rnd = new Random();

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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine("|");
    }
}

void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
    Console.WriteLine();
}

int[,] array2D = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2D);
ChangeMatrix(array2D);
PrintMatrix(array2D);
