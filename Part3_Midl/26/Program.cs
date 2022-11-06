// 26. Возведите число А в натуральную степень B используя цикл

int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void NumberDegree(int num, int degr)
{
    int res = 1;
    for (int i = 1; i <= degr; i++)
    {
        res = res*num;
    }
    System.Console.WriteLine($"{num} в степени {degr} равно {res}");
}


int osn = SetNumber("Введите основание A:");
int step = SetNumber("Введите степень B:");
NumberDegree(osn, step);
