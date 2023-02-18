
static int Ack(int m, int n)
{
    if (m==0) 
    {
        return n+1;
    }

    else
    {
        if (m>0 && n==0) 
        {
            return Ack(m-1, 1);
        }
        else
        {
             return Ack(m-1, Ack(m,n-1));
        }
    }

}
Console.WriteLine("insert m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("insert n");
int n = Convert.ToInt32(Console.ReadLine());
Ack(m, n);
Console.WriteLine(Ack(m,n));