Console.WriteLine("You are going to insert the coordinates of 2 dots in the following order: x1, y1, z1, x2, y2, z2");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
double n = Math.Sqrt((x2-x1)*(x2-x1)+ (y2-y1)*(y2-y1)+ (z2-z1)*(z2-z1));
Console.WriteLine(n);