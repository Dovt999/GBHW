int[] nums = new int[8];
int i = 0;
Console.WriteLine("Please insert 8 numbers");
while(i<nums.Length){
    nums[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.WriteLine("Your array is: ");
foreach (int j in nums) 
{
  Console.Write(j.ToString() + " ");
}
