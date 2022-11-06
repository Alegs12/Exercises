// 24. Найти кубы чисел от 1 до N



System.Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write("1");
for (int i = 2; i <= n; i++)
{
    System.Console.Write(", " + i*i*i);
}
