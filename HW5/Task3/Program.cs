Console.WriteLine("How many numbers do you need?");
int numamount = Convert.ToInt32(Console.ReadLine());
double[] array = new double[numamount];
array[0] = Convert.ToDouble(Console.ReadLine());
double max = array[0], min = array[0];
for (int i = 1; i < numamount; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}

foreach (double i in array)
{
    Console.Write(i.ToString() + " ");
}

Console.WriteLine("\n" + (max - min).ToString());