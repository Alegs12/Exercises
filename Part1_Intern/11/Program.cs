// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа


int numb = new Random().Next(10, 100);

int dec = numb / 10;
int num = numb % 10;

if (dec > num) Console.WriteLine($"В числе {numb} наибоьшая цифра {dec}");
else if (dec < num) Console.WriteLine($"В числе {numb} наибоьшая цифра {num}");
else Console.WriteLine($"В числе {numb} цифры одинаковые");
