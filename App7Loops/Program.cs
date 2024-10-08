using System.Runtime.CompilerServices;

int i = 0; // initialization

Console.WriteLine("while loop");

while (i < 10)
{ // condition
    Console.WriteLine(i);
    i++; // update
}

Console.WriteLine("do while loop");
int j = 0;

do
{
    Console.WriteLine(j);
    j++;
}
while (j < 10);


Console.WriteLine("for loop");

bool logging = true;

for (int k = 0; k < 10; k++)
{
    Console.WriteLine(k);

    if (k == 7)
    {
        if (logging == true)
        {
            Console.WriteLine("We found 7!");
        }
    }
}

Console.WriteLine("for loop, starting at the end");

for (int l = 9; l >= 0; l--)
{
    Console.WriteLine(l);
}

Console.WriteLine("Nested For loop - Rectangle");
for (int p = 9; p >= 0; p--)
{  // Nested For loop - Rectangle
    for (int r = 9; r >= 0; r--)
    {
        Console.Write(r + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Nested For loop - Triangle");

for (int p = 9; p >= 0; p--)
{  // Nested For loop  - Triangle
    for (int r = p; r >= 0; r--)
    {
        Console.Write(r + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Nested while loop - Triangle");

int s = 9;

while (s >= 0)
{
    int t = s;

    while (t >= 0)
    {
        Console.Write(t + " ");
        t--;
    }
    Console.WriteLine();
    s--;
}
