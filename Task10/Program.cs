int a,b;
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
void sum(int a,int b)
{
    if(a<=b) {if(a%2==0) {System.Console.Write(a + " ");} sum(a+1,b);}
}
void sum1(int a,int b)
{
    if(a<=b) {if(a%2!=0) {System.Console.Write(a + " ");} sum1(a+1,b);}
}
sum(a,b);
System.Console.WriteLine();
sum1(a,b);