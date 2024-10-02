
namespace App5CreatingClasses;

public class Person
{
    string middleName = "Fearless"; // A field is similar to a property but it is private, used to store data inside a class > CONVENTION: The name of a field starts with a lowerCase letter
    public string FirstName { get; set; } // Property

    public string LastName { get; set; } // Property

    public string FullName // We can customize a property
    {
        get { return FirstName + " " + LastName; }

    }


    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }

}
