Console.WriteLine("First let's generate an array");
Console.WriteLine("Insert the amount of lines (m)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert the amount of columns (n)");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
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
GetArray(m, n);
ShowArray(array);
Console.WriteLine("Now let's find the number");
Console.WriteLine("Insert the line of your number");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert the column of your number");
int column = Convert.ToInt32(Console.ReadLine());

if ((line > m) || (column > n)) Console.WriteLine("The number doesn't exist");
else
{
    Console.WriteLine("Your number is " + (array[line-1, column-1]).ToString());
}
