using System.Net;
using App6Conditionals;

Person person = new Person();
person.FirstName = "Vivens";
person.LastName = "Ndatinya";

Console.WriteLine("What do you think the name is?");
string fullNameGuess = Console.ReadLine();

Console.WriteLine("Second Guess?");
string fullNameGuess2 = Console.ReadLine();


if(person.FullName == fullNameGuess) { // Expression
    Console.WriteLine("You got the name! You Win");
}
else if(person.FullName == fullNameGuess2) { 
    Console.WriteLine("Your second guess is right! you get 1/2 points.");
}
else { 
    Console.WriteLine("Sorry, you don't know the name!");
}


/* Logical and comparison Operators */
Console.WriteLine("Yo noob wuts ur age?");
int age = Int32.Parse(Console.ReadLine());

Console.WriteLine("Dawg whats the pass?");
string password = Console.ReadLine();

if(age > 12 && password == "password123") { 
    Console.WriteLine("Welcome! You're at least a teenager and got correct password");
}

if(!(age > 12)) { // Logical operator operator ! (NOT)
    Console.WriteLine("Sorry, you're underage");
}

string name2 = "Vivens";

switch(name2) { 
    case "Vivens":
        Console.WriteLine("You are so legit");
        break;
    case "Bob":
        Console.WriteLine ($"Holà {name2}");
        break;
    default:
        Console.WriteLine("Who are you?");
        break;
}

/* Ternary operator */
bool correct = true;
int pointsEarned = correct ? 10 : 0;
Console.WriteLine(pointsEarned);


