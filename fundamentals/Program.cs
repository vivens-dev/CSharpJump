using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize array 
            List<Person> people = new List<Person>()
            {
                new Person { FirstName = "Kate", LastName = "Smith", Age = 14, Hobby = "Soccer"},
                new Person {FirstName = "Mike", LastName = "Johnson", Age = 30, Hobby = "Basketball"},
                new Person{ FirstName = "Bob", LastName = "Doe", Age = 90, Hobby = "Cooking"}
            };

            Person person;

            Console.WriteLine("DRINKING:");
            // for loop
            for (int i = 0; i < people.Count; i++)
            {
                person = people[i];

                // if statement
                if (person.Age < 21)
                {
                    // String interpolation
                    Console.WriteLine($"{person.FirstName} {person.LastName}: You are too young to drink");
                }
                else if (person.Age >= 21 && person.Age > 80)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName}: Get a drink and have fun");
                }
                else
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName}: You are too old to drink, please take a break");
                }
            }
            
            // Output
            Console.WriteLine("");
            Console.WriteLine("HOBBY MOTIVATION:");

            // foreach
            foreach (Person p in people)
            {
                switch (p.Hobby)
                {
                    case "Basketball":
                        Console.WriteLine($"{p.FirstName} {p.LastName}: Awesome, be the next Michael Jordan");
                        break;
                    case "Soccer":
                        Console.WriteLine($"{p.FirstName} {p.LastName}: Fantastic, be the next Pele");
                        break;
                    case "Cooking":
                        Console.WriteLine($"{p.FirstName} {p.LastName}: Nice, I want to try your food");
                        break;
                    default:
                        Console.WriteLine($"{p.FirstName} {p.LastName}: Sorry. That's laziness, start doing something");
                        break;
                }
            }

            // Find age and hobby for Mike Johnson

            var mikeJohsonInfo = people.Find(p => p.LastName == "Johnson" && p.FirstName == "Mike");
            
            if(mikeJohsonInfo != null) { 
                Console.WriteLine("");
                Console.WriteLine($"Information for {mikeJohsonInfo.FirstName} {mikeJohsonInfo.LastName}:");
                Console.WriteLine($"Age: {mikeJohsonInfo.Age}");
                Console.WriteLine($"Hobby: {mikeJohsonInfo.Hobby}");
            }

        }
    }
}
