// 22. Найти расстояние между точками в пространстве 2D/3D


// 2D
double Coordinats3D(int xA, int yA, int xB, int yB)
{
    double length = Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2));
    return length;
    
}


Console.WriteLine("Введите координаты X, Y для точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X, Y для точки A: ");
int xB = Convert.ToInt32(Console.ReadLine());
int yB = Convert.ToInt32(Console.ReadLine());

double leng = Coordinats3D(xA, yA, xB, yB);
System.Console.WriteLine($"Длинна отрезка AB = {leng}");


// //3D
// double Coordinats3D(int xA, int yA, int zA, int xB, int yB, int zB)
// {
//     double length = Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2) + Math.Pow(zB-zA, 2));
//     //System.Console.WriteLine($"Длинна отрезка AB = {length}");
//     return length;
    
// }


// Console.WriteLine("Введите координаты X, Y. Z для точки A: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// int yA = Convert.ToInt32(Console.ReadLine());
// int zA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты X, Y. Z для точки A: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// int yB = Convert.ToInt32(Console.ReadLine());
// int zB = Convert.ToInt32(Console.ReadLine());

// double leng = Coordinats3D(xA, yA, zA, xB, yB, zB);
// System.Console.WriteLine($"Длинна отрезка AB = {leng}");