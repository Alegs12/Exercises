 // 1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2*num2) 
    {
    System.Console.WriteLine($" Число {num1} является квадратом числа {num2}");
    }
else 
    {
    System.Console.WriteLine($" Число {num1} не является квадратом числа {num2}");
    }