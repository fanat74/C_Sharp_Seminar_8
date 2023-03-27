// Задача 53.Задайте двухмерный массив. Напишите программу
// которая поменяет местами первую и последнюю строку массива

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

void ChangeStringMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        {
            int temp = matrix[0, j];
            matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
            matrix[matrix.GetLength(0) - 1, j] = temp;
        }
    }
    Console.WriteLine();
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
ChangeStringMatrix(array2D);
PrintMatrix(array2D);