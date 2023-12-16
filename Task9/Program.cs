int a, b;
a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];

void sum(ref int[] arr,int b)
{
    for (int i = 0; i < a; i++)
    {
        arr[i] += b;
    }
}

for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
b = Convert.ToInt32(Console.ReadLine());

sum(ref arr,b);
for (int i = 0; i < a; i++)
{
    System.Console.Write(arr[i] + " ");
}