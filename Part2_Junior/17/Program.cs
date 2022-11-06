// 17. По двум заданным числам проверять является ли одно квадратом другого


System.Console.WriteLine("Введите два числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{
    if (num1 == num2*num2) System.Console.WriteLine($"Число {num1} является квадратом числа {num2}");
    else System.Console.WriteLine("Числа не связаны квадратичной зависимостью");
}
else 
{
    if (num2 == num1*num1) System.Console.WriteLine($"Число {num2} является квадратом числа {num1}");
    else System.Console.WriteLine("Числа не связаны квадратичной зависимостью");
}