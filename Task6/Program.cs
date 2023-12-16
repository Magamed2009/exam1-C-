int a;
a=Convert.ToInt32(Console.ReadLine());
if(a==1) {System.Console.WriteLine(0); return ;}
if(a==2) {System.Console.WriteLine(1); return ;}
void sum(int a)
{
    int cnt=2,b=0,c=1,sum=0;
    System.Console.Write(0 + " " + 1 + " ");
    while(cnt!=a)
    {
        sum=b;
        b=c;
        c=sum+b;
        System.Console.Write(c + " ");
        cnt++;
    }
}
sum(a);