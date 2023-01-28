Console.WriteLine("How many numbers do you want");
int numamount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Generating numbers...");
int[] array = new int[numamount];
Random rnd = new Random();
int i, evenamount = 0;
for (i = 0; i < numamount; i++)
{
    array[i] = rnd.Next(100, 999);
    if (array[i] % 2 == 0)
    {
        evenamount++;
    }
}
foreach (int j in array)
{
    Console.Write(j.ToString() + " ");
}
Console.WriteLine("The amount of even numbers is " + evenamount.ToString());