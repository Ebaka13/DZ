Console.WriteLine("Введите координаты точки 1 ");
Console.Write("x1 =: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 =: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 =: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2 ");
Console.Write("x2 =: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 =: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 =: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(double coor1, double coor2, double coor3, double coor4, double coor5, double coor6)
{
    double res1 = coor4 - coor1;
    double res2 = coor5 - coor2;
    double res3 = coor6 - coor3;
    double dist = Math.Sqrt((Math.Pow(res1, 2) + Math.Pow(res2, 2) + Math.Pow(res3, 2)));
    return dist;
}