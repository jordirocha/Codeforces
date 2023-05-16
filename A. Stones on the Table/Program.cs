var stones = Console.ReadLine();
var colors = Console.ReadLine();

var n = 0;

for (var i = 0; i < colors.Length - 1; i++) if (colors[i] == colors[i + 1]) n++;

Console.WriteLine(n);