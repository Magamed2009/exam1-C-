int a,b,cnt=0;
a=Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
b=Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    if(arr[i]==b) {cnt++;}
}
System.Console.WriteLine(cnt);