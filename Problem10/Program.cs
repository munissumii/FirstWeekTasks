Console.WriteLine("Leap years : ");

for (int year = 2022; year < year + 80; year++)
{
    if (year % 4 != 0)
    { 

    }
    else
    {
        if(year % 100 != 0 )
        {
            Console.WriteLine(year);
        }
        else
        {
            if(year % 400 == 0)
            {
                Console.WriteLine(year);
            }
        }
    }

}

