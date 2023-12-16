int a,b;
System.Console.Write("x = ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("y = ");
b=Convert.ToInt32(Console.ReadLine());
void sum(ref int a,ref int b)
{
    int c;
    c=a;
    a=b;
    b=c;  
}
sum(ref a, ref b);
 System.Console.Write($"x = {a}");
    System.Console.WriteLine();
    System.Console.Write($"y = {b}"); 