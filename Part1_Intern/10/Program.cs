// 10. Показать вторую цифру трёхзначного числа


Console.WriteLine("Введите трехзначное число :");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num <1000) {
    int ost10 = num / 10;
    int res = ost10 % 10;
    System.Console.WriteLine($"Вторая цифра числа {num} -> {res}");
}
else {
    System.Console.WriteLine("Число не трехзначное");
}