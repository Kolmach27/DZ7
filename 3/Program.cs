int [,] CreateArray(int lenRows, int lenColumns)
{
        int [,] array = new int[lenRows, lenColumns];
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)  
        {
                for (int j = 0; j < array.GetLength(1); j++)  
                {
                        array[i, j] = random.Next(1, 99);  
                }
        }
        return array; 
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] array = CreateArray(3, 4);  
PrintArray(array);

void CalculateAverage(int[,] array)
{
    Console.Write("Среднее арифметическое:");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        double average = sum / array.GetLength(0);
        Console.Write($"{average:f1}; ");
    }
}

CalculateAverage(array);