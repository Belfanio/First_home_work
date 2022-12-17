Console.Write("Input first number ");
int first = int.Parse(Console.ReadLine() ?? "");
Console.Write("Input second number ");
int second = int.Parse(Console.ReadLine() ?? "");
if (first > second)
{
    Console.WriteLine($"{first} > {second} ");
}
else if (second > first)
{
    Console.WriteLine($"{second} > {first}");
}
else
{
    Console.WriteLine($"{second} = {first}");
}