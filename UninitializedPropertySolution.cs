public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass(int initialValue)
    {
        MyProperty = initialValue;
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now MyProperty is guaranteed to have an assigned value
    }
}

// usage
ExampleClass obj = new ExampleClass(10);
obj.MyMethod(); //Output:10