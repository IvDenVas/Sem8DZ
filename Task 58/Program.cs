// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
Console.Clear();

int rows = UserInput("Введите количество строк исходных матриц: ", "Ошибка ввода!");
int columns = UserInput("Введите количество столбцов исходных матриц: ", "Ошибка ввода!");

int[,] arrayOne = GetArray(rows, columns, -10, 10);
int[,] arrayTwo = GetArray(rows, columns, -10, 10);
int[,] res = MultiplicationTwoMatrix(arrayOne, arrayTwo);

PrintMatrix(arrayOne);
Console.WriteLine();
PrintMatrix(arrayTwo);
Console.WriteLine("===============");
PrintMatrix(res);

int[,] MultiplicationTwoMatrix(int[,] arrOne, int[,] arrTwo)
{
    int[,] result = new int[arrayOne.GetLength(0),arrayOne.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = arrOne[i, j] * arrayTwo[i, j];
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

int UserInput (string message, string message1)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
        if (num > 0)
            return num;
        Console.WriteLine(message1);
    }
}