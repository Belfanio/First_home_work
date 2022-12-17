
Console.Write("Input number ");
int first = int.Parse(Console.ReadLine() ?? "");
int index = 1;

while (index <= first)
{
    if (index % 2 == 0)
    {
        Console.Write($"{index} ");
    }
    index++;
}