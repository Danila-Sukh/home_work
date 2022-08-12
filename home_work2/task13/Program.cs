Console.WriteLine("Введите число: ");
int number =int.Parse (Console.ReadLine());
int count = 0;
string str = number.ToString();
  int[] b = new int[str.Length];
  for (int i = 0; i < str.Length; i++)
  {
    b[i] = int.Parse(str[i].ToString());
  if (i == 2)
  {
    Console.WriteLine(b[i]);
    count = 1;
  }
  }
   if  (count==0) Console.WriteLine("Третьей цифры нет");