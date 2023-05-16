var input = Console.ReadLine().Split(' ').Select(e => Int32.Parse($"{e}")).ToList();

var firstBanana = input[0];
var initDollars = input[1];
var numBananas = input[2];

var borrow = 0;

for (int i = 1; i <= numBananas; i++)
{
    borrow += i*firstBanana;
}

Console.WriteLine(initDollars <= borrow ? borrow-initDollars : 0);