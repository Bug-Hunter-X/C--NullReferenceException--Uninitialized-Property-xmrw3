public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Solution 1: Initialize MyProperty in the constructor
        //public ExampleClass() { MyProperty = 0; }

        // Solution 2: Check for null using an if statement
        //if (MyProperty != null)
        //    Console.WriteLine(MyProperty.ToString());

        // Solution 3: Use the null-conditional operator (?.)
        Console.WriteLine(MyProperty?.ToString()); 
    }
}