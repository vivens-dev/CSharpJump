using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

int a = - 5;

uint b = 5;  // uint is not going to let you assign a negative value

char c = 'C'; // assign a character to char

float d = 5.5F;

double e = 5.5; // Most of the time you're going to use double instead of float/decimal

decimal f = 5.5M; // decision should be used if you need precision such as for money

bool g = true;

string h = "Hello"; // string is categorized under reference types


/* Value types vs Reference types */
int i = -5;
int j = i; // Value type, the value -5 is copied into j, and if you change j, i will remain -5, which is not the case for reference types

Console.WriteLine($"The value of i: {i}");
Console.WriteLine($"The value of j: {j}");

j = 10;

Console.WriteLine($"The value of i: {i}"); 
Console.WriteLine($"The value of j: {j}"); // i and j have different values after j is changed

//An array, an example of a reference type
int[] k = { -8 };
int[] l  = k;

Console.WriteLine($"The value of k[0]: {k[0]}");
Console.WriteLine($"The value of l[0]: {l[0]}");

l[0] = 10;

Console.WriteLine($"The value of k[0]: {k[0]}"); // Reference type, when we make changes to k, the same changes are reflected by l
Console.WriteLine($"The value of l[0]: {l[0]}");

Test(k);  // Reference types can be changed inside methods
Console.WriteLine($"The value of k[0]: {k[0]}");

static void Test (int[] m) { 
     m[0] = 100;
}

int n = (int) 5.5; // Explicit type casting -> will crop off the decimal part
double p = 5; // Implicity type casting -> It's safe to convert an int to a double
// Think of data types as "backpacks", A backpack can only store items which fit its size

float q = 5.5f; // A float literal must end with 'f', you can't assign a decimal to a float without explicitly converting it

decimal r = 10.5M; // decimal is more precise than double

double s = double.NaN;

Console.WriteLine(double.IsNaN(s));

double t = double.PositiveInfinity;

double u = Math.Pow(9999, 9999999999999999999); // Generate an infinite value

Console.WriteLine($"Is u infinite: {double.IsInfinity(u)}");

double v = 50.5; 

double w = 300;

Console.WriteLine(Math.Round(v));

Console.WriteLine(Math.Floor(v));

Console.WriteLine(Math.Ceiling(v));

Console.WriteLine(Math.Truncate(v));

Console.WriteLine(Math.Min(v, w));

Console.WriteLine(Math.Max(v, w));

Console.WriteLine(Math.Abs(v));

Console.WriteLine(Math.Sign(v));







