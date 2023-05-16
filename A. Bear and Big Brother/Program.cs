int years = 0;

var weights = Console.ReadLine().Split(' ').Select(e => Int32.Parse($"{e}")).ToList();

Console.WriteLine(Years(weights[0], weights[1]));

int Years(int l, int b)
{

    if (l <= b)
    {
        years += 1;
        Years(l * 3, b * 2);
    }

    return years;
}