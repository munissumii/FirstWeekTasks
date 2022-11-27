var n = int.MaxValue;
int primeN = 0;
for(int i = 1; i < n; i++)
{
    for(int j = 2; j < i; j++)
    {
        if(i % j != 0 )
        {
            primeN = i;
        }
    }
    Console.Write($"{primeN} ");
}

Console.WriteLine(n);