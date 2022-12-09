// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
Console.Clear();

int[,] arrayOne = GetArray(2, 2, 0, 10);
int[,] arrayTwo = GetArray(2, 2, 0, 10);
int[,] res = MultiplicationTwoMatrix(arrayOne, arrayTwo);

PrintMatrix(arrayOne);
Console.WriteLine();
PrintMatrix(arrayTwo);
Console.WriteLine("Результирующая матрица будет: ");
PrintMatrix(res);

int[,] MultiplicationTwoMatrix(int[,] arrOne, int[,] arrTwo)
{
    int[,] result = new int[arrayOne.GetLength(0),arrayTwo.GetLength(1)];
    if (arrayOne.GetLength(1) == arrayTwo.GetLength(0))
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                for (int k = 0; k < arrayOne.GetLength(1); k++)
                {
                    result[i,j] += arrayOne[i, k] * arrayTwo[k, j];
                }
                
            }
        }
        
    }
    return result;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
    return result;
}

void PrintMatrix(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
