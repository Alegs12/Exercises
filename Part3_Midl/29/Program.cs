// 29. Написать программу вычисления произведения чисел от 1 до N


int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int FactorN(int num)
{
    int res = 1;
    for (int i = 1; i <=num; i++)
    {
        res *= i;
    }
    return res;
}

int result = SetNumber("Введите число N");
System.Console.WriteLine($"Произведение числе от 1 до N равняется {FactorN(result)}");