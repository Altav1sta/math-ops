using TestConsole;


Start:

Console.WriteLine($"Here is the console for testing math functions.");
Console.WriteLine();

var x = MathOps.GreatestCommonDivisor(121, 11);

Console.WriteLine(x);
Console.WriteLine();

Console.WriteLine("Press 'Enter' to relaunch");
Console.WriteLine();

if (Console.ReadKey().Key == ConsoleKey.Enter)
{
    Console.Clear();
    goto Start;
}