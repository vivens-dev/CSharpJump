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