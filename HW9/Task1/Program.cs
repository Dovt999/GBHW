void Rec(int N)
{
    if(N>=1)
    {
        Console.WriteLine(N);
        Rec(N-1);
        
    }
}

Console.WriteLine("Insert N");
int N = Convert.ToInt32(Console.ReadLine());
Rec(N);