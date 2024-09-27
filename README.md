# C#
C# is the programming language while .NET is the plaform which allows to use the C# language
C# is very intuitive, therefore I chose it as the language I think in.

# .NET
*  When you write C# code you need a way to execute the code and .NET allows you to do that
* You can write Mobile apps (Native), Web apps or Desktop app
* .NET Core is a cross-platform, it runs on Windows, Linux and macOS

## GETTING STARTED
To learn C#, it is easier to start with the *Console Application*
* Console applications just execute in the terminal, it takes input and returns output, very simple
* Learn the basics and build on that
* You can run the .NET app through the terminal (CLI) with *dotnet run*
* VS: two ways to execute your application:
    - Debug mode -> allows to set breakpoints -> step through
    - Without Debug mode

## BASIC STRUCTURE
* The right structural order of C#'s code: *namespace -> classes -> members -> method -> statements*
* A **class** has members (such as a method)
* A **method** contains a block of code
    - static void Main (string[] args) {} is the starting method by convention
    - Create the method
    - Invoke the method
    -  Arguments can be passed to methods
    -  *static* means that the method can be called directly
    -  *non-static* methods must be called on an instance of the class
    - Break the application in smaller methods, modularize the code

* A **statement** is a basic unit of execution of a program
* A **namespace** is used for organization, logical grouping
    - E.g: *using System*, *using System.Collections.Generic*

* **Arguments**
   * Allows to pass data to a method, arguments get stored into parameters
   * Command Line arguments - eg: *dotnet run -- -h*

* **Input**
    * `Console.ReadLine()` returns a string, and you need to assign it to a variable
    - Eg: `var x = Console.ReadLine()`  
    - **var** keyword instructs the compiler to infer the type of the variable from the expression on the right side of the initialization statement. The inferred type may be a built-in type, an anonymous type, a user-defined type, or a type defined in the .NET class library.


* **Variables**
    * A *variable* stores some value and you can refer it later in the code, variables can be used in an expression
    * An *identifier* - what we call the variable, the following are rules for identifiers
    - Cannot start with a number
    - can start with underscore
    - C# is case sensitive
    - Every variable has a data type such `int`, `string`, `var`
    - **var** does not mean dynamically type, it's inferred typed
    -  variables allow the code to be dynamic and more useful

* **Literal**
    * A *literal* is a fixed value that is used by the variables. A literal value can be either an integer, float, string, etc.

* **Expression**
    * An expression evaluates a value

* **Operator**
    * it words on operands
    * Operand - the thing(s) that the operator works on
    *  Operands and operators are combined into an expression






    









