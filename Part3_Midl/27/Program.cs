// 27. Определить количество цифр в числе

int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int CountOfNumbers(int num)
{
    int i = 0;
    
    while (num > 0)
    {
        num = num / 10;
        i++;
    }
return i;
}

int num = SetNumber("Введите число");
int summ = CountOfNumbers(num);
System.Console.WriteLine($"Количество цифр в числе {num} равняется {summ}");

