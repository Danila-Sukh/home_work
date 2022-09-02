int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 20);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
    return array;
}
void Sort(int[,] array)
{
    int sum = 0;
    int counter = -5;
    int small = 1000;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < small)
        {
            small = sum;
            counter = i;
        }
        sum = 0;
    }
    Console.WriteLine("Строка с наименьшей суммой " + (counter + 1));
}
int[,] array = new int[6, 4];
Sort(FillArray(array));
