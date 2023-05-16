var input = Console.ReadLine().Split(' ').Select(e => Int32.Parse($"{e}")).ToList();

var number = input[0];

for (int i = 0;i < input[1]; i++)
{
	if (number%10==0)
	{
		number = number / 10;
	}
	else
	{
		number -= 1;
	}


}

Console.WriteLine(number);