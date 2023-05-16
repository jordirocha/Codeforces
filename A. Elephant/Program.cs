var input = Int32.Parse(Console.ReadLine());

var count = 0;

while (input > 0)
{
    if (input >= 5)
    {
        count++;
        input -= 5;
    }
    else if (input >= 4)
    {
        count++;
        input -= 4;
    }
    else if (input >= 3)
    {
        count++;
        input -= 3;
    }
    else if (input >= 2)
    {
        count++;
        input -= 2;
    }
    else
    {
        count++;
        input -= 1;
    }
}

Console.WriteLine(count);