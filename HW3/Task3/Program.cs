Console.WriteLine("Insert a number");
int num = Convert.ToInt32(Console.ReadLine());
int i=1;
while(i<num+1){
    Console.Write(i*i*i);
    if(i<num) Console.Write(", ");
    else Console.Write(".");
    i++;
}