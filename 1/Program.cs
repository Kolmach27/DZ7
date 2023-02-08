double[,] CreateArray()
{
    double[,] array = new double[3, 4];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int g = 0; g < array.GetLength(1); g++)
        {
            array[i, g] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int g = 0; g < array.GetLength(1); g++)
        {
            Console.Write(array[i, g] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
double[,] result = CreateArray();
PrintArray(result);