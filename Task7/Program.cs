int a;
a=Convert.ToInt32(Console.ReadLine());
void sum(int a)
{
    int cnt=0,b=0;
    b=a;
    while(a!=0) {cnt+=a%10; a/=10;}
    System.Console.WriteLine($"The sum of the digits of the number {b} is : {cnt}");
}
sum(a);