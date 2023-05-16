var text = Console.ReadLine();

var upper = String.Concat(text.Where(x => Char.IsUpper(x)));
var lower = String.Concat(text.Where(x => Char.IsLower(x)));

if (upper.Length > lower.Length) Console.WriteLine(text.ToUpper());
else Console.WriteLine(text.ToLower());