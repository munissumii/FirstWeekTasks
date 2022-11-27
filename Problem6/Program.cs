Console.WriteLine("Please, enter the number");
var n = int.Parse(Console.ReadLine()!);

int sum = 0, mSum = 0;

Console.WriteLine("Enter \"1\" to compute the sum, enter \"2\" to compute the product");
var m = Console.ReadLine();

switch(m)
{
    case "1":
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
        break;
    case "2":
        for (int i = 1; i <= n; i++)
        {
            mSum += i * i+1;
        }
        Console.WriteLine(mSum);
        break;

}