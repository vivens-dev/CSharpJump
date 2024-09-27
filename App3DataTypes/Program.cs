using System.Runtime.Intrinsics.Arm;

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



