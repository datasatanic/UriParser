// See https://aka.ms/new-console-template for more information

if (args.Length == 0)
{
    return;
}

Console.Title = "UriParser";

Uri uri = new Uri(System.Net.WebUtility.UrlDecode(args[0]));


Console.WriteLine();
var def_color = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Uri: ");
Console.ForegroundColor = def_color;
Console.WriteLine(uri);
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Scheme: ");
Console.ForegroundColor = def_color;
Console.WriteLine(uri.Scheme);

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Host: ");
Console.ForegroundColor = def_color;
Console.WriteLine(uri.Host);

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Port: ");
Console.ForegroundColor = def_color;
Console.WriteLine(uri.Port);

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Path: ");
Console.ForegroundColor = def_color;
Console.WriteLine(uri.AbsolutePath);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Query Params:");
foreach (var param in uri.Query[1..].Split('&'))
{
    string[] p = param.Split('=');
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"\t{p[0]} = ");
    Console.ForegroundColor = def_color;
    Console.WriteLine(p[1]);
}