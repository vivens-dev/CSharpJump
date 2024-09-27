Console.WriteLine(args[0]); //Read command line args
Print(); // Call method

void Print()
{
    var name = Console.ReadLine(); // Read input
    Console.WriteLine($"I love {name}"); // Output, String interpolation
    Console.WriteLine("Dunk!");
}
