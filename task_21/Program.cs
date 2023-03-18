Double Dist (int x1, int y1, int z1, int x2, int y2, int z2)
{
double res = 0;
res = Math.Sqrt( (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
return res;
}


Console.WriteLine("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


Console.Write(Math.Round(Dist (x1, y1, z1, x2, y2, z2), 3));