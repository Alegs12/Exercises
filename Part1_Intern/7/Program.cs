//  7. Показать числа от -N до N

Console.WriteLine("Введите число 1: ");
int num = Convert.ToInt32(Console.ReadLine());

int numRev = -num;

for (int i = numRev; i <= num; i++)
    System.Console.Write(i + " ");