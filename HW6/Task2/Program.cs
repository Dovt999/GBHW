// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x = (b2 - b1)/(k1-k2)
// y = k1 * x + b1
// (x; y)

void intersection(double k1, double k2, double b1, double b2)
{
    Console.WriteLine("(" + ((b2 - b1) / (k1 - k2)).ToString() + "; " + (((b2 - b1) / (k1 - k2)) * k1 + b1).ToString() + ")");
}
Console.WriteLine("Insert k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert b2");
double b2 = Convert.ToInt32(Console.ReadLine());

intersection(k1, k2, b1, b2);