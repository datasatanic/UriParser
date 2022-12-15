// See https://aka.ms/new-console-template for more information

if (args.Length == 0)
{
    return;
}

Console.Title = "UriParser";
Uri uri = new Uri(args[0]);

Console.WriteLine($"Uri: {uri}");
Console.WriteLine();
Console.WriteLine($"Scheme: {uri.Scheme}");
Console.WriteLine($"Host: {uri.Host}");
Console.WriteLine($"Port: {uri.Port}");
Console.WriteLine($"Path: {uri.AbsolutePath}");
Console.WriteLine("Query Params:");
foreach (var param in uri.Query[1..].Split('&'))
{
    string[] p = param.Split('=');
    Console.WriteLine($"\t{p[0]}= {p[1]}");
}

