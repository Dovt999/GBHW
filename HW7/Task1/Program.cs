Console.WriteLine("Insert the amount of lines (m)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert the amount of columns (n)");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];
void ShowArray(double[,] array)
{
    for(int i=0; i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            Console.Write(array[i,j].ToString() + " ");
        }
        Console.WriteLine("");
    }
}
void GetArray(int m, int n)
{
    Random rnd = new Random();
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            array[i,j] = rnd.NextDouble()*Convert.ToDouble(rnd.Next(-100, 100));
        }
    }
}
//  не обращайте внимания (-1^rnd.Next(1, 2)*NextDouble()*10^(rnd.Next(0,8)) )
GetArray(m,n);
ShowArray(array);
