// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[] list =CreateUniqueMassive(2,2,2,1,30);
int[,,] array = GetArray(2, 2, 2, list);

PrintMatrix(array);

int[] CreateUniqueMassive(int x, int y, int z, int minValue, int maxValue )
{
    int[] list = new int[x * y * z];
    for (int i = 0; i < list.Length; i++)
    {
        bool elementUnique;
        do
        {
            list[i] = new Random().Next(minValue, maxValue + 1);
            elementUnique = true;
            for (int j = 0; j < i; j++)
            {
                if (list[i] == list[j]) elementUnique = false;
            }

        } while (!elementUnique);
    }
    return list;

}

int[,,] GetArray(int x, int y, int z, int[] array)
{
    int[,,] result = new int[x, y, z];
    int count = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
    
            for (int k = 0; k < z; k++)
            {
                
                result[i, j, k] = array[count];
                count++;
            }
            
        }

    }
    return result;
}

void PrintMatrix(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.WriteLine($"{inArray[i, j, k]} - [{i},{j},{k}]   ");
            }
            // Console.Write($"{inArray[i, j, k]}, [{i},{j},{k}]   ");
        }
        // Console.WriteLine();
    }
}