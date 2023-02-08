Console.Write("Введите строку: ");
int m1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int n1 = Convert.ToInt32(Console.ReadLine()) - 1;
int m = 3; 
int n = 4; 
Random random = new Random();
int[,] array = new int[n, m];
Console.WriteLine("Массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
{
    array[i, j] = random.Next(1, 99);
Console.Write("{0} ", array[i, j]);
}
Console.WriteLine();
}
    if (m1 < 0 | m1 > array.GetLength(0) - 1 | n1 < 0 | n1 > array.GetLength(1) - 1)
{
Console.WriteLine("Элемента нет");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", array[m1, n1]);
}
Console.ReadLine();
 