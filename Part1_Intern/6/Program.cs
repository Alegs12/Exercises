//  6. Выяснить является ли число чётным

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) System.Console.WriteLine($"Число {num} является четным");
else System.Console.WriteLine($"Число {num} не является четным");