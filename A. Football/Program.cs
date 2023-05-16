var input = Console.ReadLine().ToList();

var zeros = 0;
var ones = 0;

for (int i = 0; i < input.Count; i++)
{
    if (input[i] == '0') 
    {
        zeros++;
        if (zeros == 7)
        {
            Console.WriteLine("YES");
            break;
        }
    }
    else
    {
        zeros = 0;
    }

    if (input[i] == '1')
    {
        ones++;
        if (ones == 7)
        {
            Console.WriteLine("YES");
            break;
        }
    }
    else
    {
        ones = 0;
    }

}

if (ones < 7 && zeros <7)
{
    Console.WriteLine("NO");
}