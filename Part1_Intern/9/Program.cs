//  9. Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число :");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num <1000) {
    int res = num %10;
    System.Console.WriteLine($"Последня цифра числа {num} -> {res}");
}
else {
    System.Console.WriteLine("Число не трехзначное");
}