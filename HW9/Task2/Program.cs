int sum = 0;
void Rec(int N, int M)
{
    if(N>=M)
    {
        
        Rec(N-1, M);
        sum = sum + N;
    }

}
    
Console.WriteLine("Insert M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert N");
int N = Convert.ToInt32(Console.ReadLine());

Rec(N, M);
Console.WriteLine(sum);
