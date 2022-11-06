// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0


Console.WriteLine("Введите координату Х: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату У: ");
int numY = Convert.ToInt32(Console.ReadLine());

if (numX>0 && numY>0) System.Console.WriteLine("Первая четверть");
else if (numX<0 && numY>0) System.Console.WriteLine("Вторая четверть");
else if (numX<0 && numY<0) System.Console.WriteLine("Третья четверть");
else if (numX>0 && numY<0) System.Console.WriteLine("Четвертая четверть");
else System.Console.WriteLine("X или Y не должны быть равны нулю");