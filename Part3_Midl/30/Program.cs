// 30. Показать кубы чисел, заканчивающихся на четную цифру



System.Console.WriteLine("Введите положительное число N");
int n = Convert.ToInt32(Console.ReadLine());

if (n <=0) System.Console.WriteLine("Введите положительное число N");
else 
{
    if (n==1) System.Console.WriteLine("Нет кубов, оканчивающихся на четную цифру");
    else
    {
        System.Console.Write("8");
        for (int i = 3; i <= n; i++)
        {
            if (i*i*i%2 == 0)
            System.Console.Write(", " + i*i*i);
        }   
    }
}
