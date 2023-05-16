var input = Console.ReadLine();

var luckyNumbers = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] =='4' || input[i] == '7')
    {
        luckyNumbers++;
    }
   
}

if (luckyNumbers == 4 || luckyNumbers == 7)
{
    Console.WriteLine("YES");
}
else Console.WriteLine("NO");
