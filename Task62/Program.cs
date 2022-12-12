//Заполните спирально массив 4 на 4.

Console.Clear();

int[,] array = GetArray(4, 4);

PrintArray(array);


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    int l = 1;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = l;
            l++;
        }

    }
    for (int i = 1; i < 2; i++)
    {
        for (int j = 3; j < 4; j++)
        {
            result[i, j] = l;
            l++;
        }

    }
    for (int i = 2; i < 3; i++)
    {
        for (int j = 3; j < 4; j++)
        {
            result[i, j] = l;
            l++;
        }

    }
    for (int i = 3; i < 4; i++)
    {
        for (int j = 3; j >= 0; j--)
        {
            result[i, j] = l;
            l++;
        }

    }
    for (int i = 2; i > 0; i--)
    {
        for (int j = 0; j < 1; j++)
        {
            result[i, j] = l;
            l++;
        }

    }
    for (int i = 1; i < 2; i++)
    {
        for (int j = 1; j < 3; j++)
        {
            result[i, j] = l;
            l++;
        }

    }
    for (int i = 2; i > 1; i--)
    {
        for (int j = 2; j > 0; j--)
        {
            result[i, j] = l;
            l++;
        }

    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine( );
    }
}
