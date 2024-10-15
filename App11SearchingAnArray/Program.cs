int[] grades = { 36, 430, 23, 10 };

bool found = false;

for (int i = 0; i < grades.Length; i++)
{
    if (grades[i] == 40)
    {
        Console.WriteLine("We found it!");
        found = true;
        break;
    }
}

if (!found)
{
    Console.WriteLine("NOT FOUND :(");
}

//C# has a method to search an array -> Array.IndexOf();

Console.WriteLine(Array.IndexOf(grades, 430));
