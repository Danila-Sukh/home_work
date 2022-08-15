Console.WriteLine("Введите число до которого будут кубы");
int a=int.Parse (Console.ReadLine());
int i=1;
while (i<=a)
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.Write(Math.Pow(i, 3) + " ");
  i++;
}