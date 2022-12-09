// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
Console.Clear();

int rows = UserInput("Введите количество строк: ", "Ошибка ввода!");
int columns = UserInput("Введите количество столбцов: ", "Ошибка ввода!");

int[,] array = GetArray(rows, columns, 0, 10);
int[] arraySummaElementov = SummaElementsRows(array);
int minElArray = MinElementsArray(arraySummaElementov, array);

PrintMatrix(array);
Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {minElArray + 1} строка");



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

int MinElementsArray(int[] array, int[,] inArray)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;

        } 
        
    }
    return minIndex;
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

