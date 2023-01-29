Console.WriteLine("How many numbers are you going to insert?");
int numamount = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[numamount];
Console.WriteLine("Insert the numbers");
int amount = 0;
for(int i=0;i<numamount;i++)
{
    nums[i] = Convert.ToInt32(Console.ReadLine());
    if(nums[i]>0) amount++;
}
Console.WriteLine("The amount of numbers greater than 0 is " + amount.ToString());
