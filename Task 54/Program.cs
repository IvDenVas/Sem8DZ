// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int rows = UserInput("Введите количество строк: ", "Ошибка ввода!");
int columns = UserInput("Введите количество столбцов: ", "Ошибка ввода!");

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);
Console.WriteLine();

ArraySortRows(array);

PrintArray(array);

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

void ArraySortRows(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        //int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(1) - 1; k++)
            {
                if (inArray[i, k] < inArray[i, k + 1])
                {
                    int temp = inArray[i, k + 1];
                    inArray[i, k + 1] = inArray[i, k];
                    inArray[i, k] = temp;
                }
                //Console.Write($"{inArray[i,k]} ");
            }  
            //Console.Write($"{inArray[i,j]} ");    
        }
        //Console.WriteLine();    
        
    }
}

void PrintArray(int[,] inArray)
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