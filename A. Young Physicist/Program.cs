var lines = Int32.Parse(Console.ReadLine());

var result = new int[3];

for (int i = 0; i < lines; i++)
{
    var line = Console.ReadLine().Split(' ').Select(e => Int32.Parse($"{e}")).ToList();
    result[0] = line[0] + result[0];
    result[1] = line[1] + result[1];
    result[2] = line[2] + result[2];
}

if (result[0] == 0 && result[1] == 0 && result[2] == 0) Console.WriteLine("YES");
else Console.WriteLine("NO");