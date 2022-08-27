void FillArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
            Console.Write(Math.Round(array[i, j], 2) + " ");
        }
        Console.WriteLine(" ");
    }

}
Console.WriteLine("Введите M и N по очереди: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
FillArray(m, n);