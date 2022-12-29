
Console.WriteLine("Insert a positive 5-digit number");
int num = Convert.ToInt32(Console.ReadLine());
if((num < 10000) || (num > 99999)) Console.WriteLine("Incorrect number. Please, insert a 5-digit positive number next time");
else
{
    if((num/10000 == num%10) || (num/1000 == (num/10)%10)) Console.WriteLine("Your number is a polindrome");
    else
    {
        Console.WriteLine("Your number is not a polindrome");
    }

}
