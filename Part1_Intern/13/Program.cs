// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.


Console.WriteLine("Введите заданное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0) System.Console.WriteLine($"Число {num1} кратно {num2}");
else System.Console.WriteLine($"Число {num1} не кратно {num2}");