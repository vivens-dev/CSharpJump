using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

char letter = 'a'; // Must use single quotes for char
int  number = 'a'; // char and integer are interchangeable
char escaped = '\t'; // Escaped character, we're telling the computer that we want to interpret this differently

Console.WriteLine("Hello\tVivens");

char letter2 = (char)97;

string name = "Vivens";

string name2 = name;

name += " Ndatinya";

Console.WriteLine(name);

Console.WriteLine(name2); // Strings act similar in nature as simple types

char[] characters = {'h', 'e', 'l', 'l', 'o'};

string greeting = new string(characters);

Console.WriteLine(greeting);

string message = $"Hello my name is {name}, and I'd like to say {greeting}";

Console.WriteLine(message);

/* String's properties and methods */
Console.WriteLine(name.Length);
Console.WriteLine(name.CompareTo("Worthy"));
Console.WriteLine(name.IndexOf("vens"));

string intro = "hello my name is Caleb!";

string[] words = intro.Split(" ");

Console.WriteLine(words[1]);

/* string's escape sequence */
string name3 = "\a\a\aHello my name is \"Vivens!\"";
Console.WriteLine(name3);

//Verbatim text with @
string filename1 = @"c:\documents\files\u0066.txt";
string filename2 = "c:\\documents\\files\\u0066.txt";

Console.WriteLine(filename1);
Console.WriteLine(filename2);
