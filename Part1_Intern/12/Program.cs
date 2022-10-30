// 12. Удалить вторую цифру трёхзначного числа


Console.WriteLine("Введите трехзначное число :");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num <1000) {
    int firstNum = num / 100;
    int thirdNum = num % 10;
    int result = firstNum*10 + thirdNum;
    System.Console.WriteLine($"Число {num} без второй цифры равняется {result}");
}
else {
    System.Console.WriteLine("Число не трехзначное");
}