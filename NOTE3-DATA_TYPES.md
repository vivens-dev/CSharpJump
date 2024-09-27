# C#'s type system

## Value Types
### 1. Simple Types
- **Signed Integral**: sbyte, int, long ->  means a number which can be positive or negative
- **Unsigned Integral**: byte, ushort, uint, ulong -> means a number that can only be positive
- **unicode character**: char -> used to store characters such as 'a', 'b', '!' ...
- **IEEE floating point**: float, double -> used to store decimal values
- **High-precision decimal**: decimal -> true or false
-  **Boolean**: bool
### 2. Enum Types
### 3. Struct Types
### 4. Nullable Value Types

## Reference Types

## Difference between a Value Type and a Reference Type
- variables of value types directly contain their data
- Variables of reference types store references to their data (objects), With reference types, two variables can reference the same object; therefore, operations on one variable can affect the object referenced by the other variable.

## Built-in types 
- Each C# type keyword is an alias for the corresponding .NET type; They are interchangeable

## Numeric Data Types
- **Signed integral**: `sbyte`, `short`, `int`, `long` - Each of these types has different number of bits for storing the number, you choose which one to use based on the size of the number you want to store - (`sbyte` -> 8 bits, `short` -> 16 bits, `int` -> 32 bits, `long` -> 64 bits), C# allows you to see the maximum and minimum values (eg. `int.MaxValue`, `int.MinValue`)
- **unsigned integral** `ushort`, `uint`, `ulong` : Unsigned means that the value stored in a uint variable is always positive and does not contain a sign bit like other integer data types.
- Think of data types as "backpacks", A backpack can only store items which fit its size

## Float, Double, Decimal
- These 3 types allow numbers after the decimal point
- `float` -> 32 bits -> You cannot assign a `double` to a `float` without explicitly converting it
- `double` -> 64 bits -> `double` has a number of properties and methods
- 99% of the time you will use `double`, the only circumstance you might need to use `float` is when you're limited on memory
- `decimal` is more precise than `double` -> eg. `decimal x = 10.5M;` -> Eg. for money, scientific precisions

## `Math` Class
- The `Math` class has a lot of functions - A `function` and a `method` are the same, the difference is that a `method` is attached to an instance of the class while a `function` is attached to the class itself



