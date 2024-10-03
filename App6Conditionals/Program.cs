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