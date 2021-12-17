using MathOps;


Start:

Console.WriteLine($"Here is the console for testing math functions.");
Console.WriteLine();

var x = ComputationalOps.LeastCommonMultiple(10343, 3245432);

Console.WriteLine(x);
Console.WriteLine();

Console.WriteLine("Press 'Enter' to relaunch");
Console.WriteLine();

if (Console.ReadKey().Key == ConsoleKey.Enter)
{
    Console.Clear();
    goto Start;
}