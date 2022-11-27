int n = int.Parse(Console.ReadLine()!);

int sum = 0;

for (int i = 1; i <= n; i++)
{
    if(i%3==0 || i%5==0)
    {
        sum += i;
        Console.Write($"{i}  ");
    }
}
Console.WriteLine();
Console.WriteLine(sum);