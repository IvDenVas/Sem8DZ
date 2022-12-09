// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
int rows = UserInput("Введите количество строк: ", "Ошибка ввода!");
int columns = UserInput("Введите количество столбцов: ", "Ошибка ввода!");

int[,] array = GetArray(rows, columns, 0, 10);
int[] arraySummaElementov = SummaElementsRows(array);
int minElArray = MinElementsArray(arraySummaElementov);
int minIndex = indexMinSummaElementsRows(arraySummaElementov, minElArray);

PrintMatrix(array);
Console.WriteLine("Строка с наименьшей суммой элементов -->>");
// PrintArrayOneDimensionalMassive(arraySummaElementov);
PrintMatrixOneIndexRow(array, minIndex);

int[] SummaElementsRows(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
            result[i] = sum;
        }
        sum = 0;
    }
    return result;
}

int MinElementsArray(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int indexMinSummaElementsRows(int[] array, int min)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == min) result = i;
    }
    return result;
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

void PrintMatrixOneIndexRow(int[,] inArray, int num)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == num) Console.Write($"{inArray[i, j]} ");
        }
    }
}

// void PrintArrayOneDimensionalMassive(int[] array)
// {
//     Console.Write($"[ ");
//     for (int i=0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.Write($"]");
// }
