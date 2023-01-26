Console.WriteLine("Insert your number:");
int num = Convert.ToInt32(Console.ReadLine());
int sum = num%10;
int digitamount = 1;

while (num/10!=0){
    digitamount++;
    num = num/10;
    sum = sum + num%10;
}
Console.Write("The number has ");
    Console.Write(digitamount);
    Console.WriteLine(" digits.");

Console.Write("the sum of numbers is: ");
Console.WriteLine(sum);