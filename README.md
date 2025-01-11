# C# NullReferenceException: Uninitialized Property

This repository demonstrates a common C# error: the `NullReferenceException`. This exception is thrown when you try to access a member (like a property or method) of an object that is currently null.

The `bug.cs` file contains code that reproduces this error. The `bugSolution.cs` file shows how to fix it.

## How to Reproduce

1. Clone this repository.
2. Open `bug.cs` in your preferred C# IDE.
3. Run the code. You should see a `NullReferenceException`.

## Solution

The `bugSolution.cs` file demonstrates several ways to avoid the `NullReferenceException`:
* **Initialization:** Explicitly assign a value to `MyProperty` when the object is created.
* **Null Checks:** Use a conditional statement (`if`) to check if `MyProperty` is null before attempting to access it.
* **Null-conditional operator (?.)**  This allows you to access a member only if the object is not null.

This example illustrates the importance of proper object initialization and null checks in C# to prevent unexpected runtime errors.