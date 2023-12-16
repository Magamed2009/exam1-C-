int a,cnt=-999999999,ctr=999999999,cnt1=0,ctr1=0;
a=Convert.ToInt32(Console.ReadLine());
int[] arr = new int [a];
for (int i = 0; i < a; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
    if(arr[i]>cnt) {cnt=arr[i]; cnt1=i;}
    if(arr[i]<ctr) {ctr=arr[i]; ctr1=i;}
}
System.Console.Write(ctr + " ");
for (int i = Math.Min(cnt1,ctr1) + 1; i <= Math.Max(cnt1,ctr1) - 1; i++)
{
    System.Console.Write(arr[i] + " ");
}
System.Console.WriteLine(cnt);
