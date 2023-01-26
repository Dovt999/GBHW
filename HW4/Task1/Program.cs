Console.WriteLine("insert A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("insert B");
int B = Convert.ToInt32(Console.ReadLine());
int i = 0;
int C = A;
for(i=1;i<B;i++){
    C=C*A;
}

Console.Write("Your answer is ");
Console.WriteLine(C);