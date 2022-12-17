Console.Write("Input first number ");
int first = int.Parse(Console.ReadLine() ?? "");
Console.Write("Input second number ");
int second = int.Parse(Console.ReadLine() ?? "");
Console.Write("Input third number ");
int third = int.Parse(Console.ReadLine() ?? "");

if (first > second && first > third)
{
    Console.WriteLine($"The maximal number is {first}");
}
else if (second > first && second > third)
{
    Console.WriteLine($"The maximal number is {second}");
}
else if (third > first && third > second)
{
    Console.WriteLine($"The maximal number is {third}");
}
else
{
    Console.WriteLine("You have two or more identical numbers");
}