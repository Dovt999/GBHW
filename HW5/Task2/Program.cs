Console.WriteLine("How many numbers do you want");
int numamount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Generating numbers...");
int[] array = new int[numamount];
Random rnd = new Random();
int i, sum = 0;
for (i = 0; i < numamount; i++)
{
    array[i] = rnd.Next(-100, 100);  //использую числа от -100 до 100, чтобы было проще проверить правильность суммирования
    if (i % 2 == 0)
    {
        sum = sum + array[i];
    }
}
foreach (int j in array)
{
    Console.Write(j.ToString() + " ");
}
Console.WriteLine("\n" + sum.ToString());