// 28. Подсчитать сумму цифр в числе


int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SummOfNumbers(int num)
{
    int sum = 0;
    int ost10 = 0;

    while (num > 0)
    {
        ost10 = num % 10;
        sum = sum + ost10;
        num = num / 10;
    }
return sum;
}

int num = SetNumber("Введите число");
int summ = SummOfNumbers(num);
System.Console.WriteLine($"Сумма цифр в числе {num} равняется {summ}");
