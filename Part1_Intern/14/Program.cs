// 14. Найти третью цифру числа или сообщить, что её нет


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
int j = 0;

do {                             // считаем количество знаков в числе, J - количество знаков
        j++;
        num1 = num1/10;
}
while (num1 > 0);
//System.Console.WriteLine(j);

if(j >= 3) 
{
    double step = Math.Pow(10, j-2);    // определяем, на сколько нужно разделить число, 
    double count = num % step;          // чтобы остаток начинался с его тетьего знака:
    double result = Math.Floor(count);  // 10, 1000, 10000 и т.д. Затем делим этот остаток на число меньшего порядка
    //System.Console.WriteLine(step);    //(1,  100,  1000  и т.д.) и округляем до ближайшего меньшего
    //System.Console.WriteLine(count);
    System.Console.WriteLine(Math.Floor(count/Math.Pow(10, j-3)));
}
else {
    System.Console.WriteLine("третьей цифры нет");
}