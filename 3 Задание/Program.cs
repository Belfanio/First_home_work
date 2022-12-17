Console.Write("Input number ");
int first = int.Parse(Console.ReadLine() ?? "");

if (first == 0)
{
    Console.WriteLine("The number is null");
}
else if (first % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}
