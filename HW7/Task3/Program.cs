Console.WriteLine("Insert the amount of lines (m)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert the amount of columns (n)");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];
void GetArray(int m, int n)
{
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(-100, 100);
        }
    }
}
void arithm2D(int[,] array2D)
{
    double sum = 0;

    for(int i = 0; i < m; i++)
    {
        sum=0;
        for (int j = 0; j < n; j++)
        {
            sum=sum+Convert.ToDouble(array2D[i,j]);
            
        }
        Console.Write((sum/(n)).ToString() + "; ");
    }
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j].ToString() + " ");
        }
        Console.WriteLine("");
    }
}

GetArray(m,n);
ShowArray(array);
arithm2D(array);