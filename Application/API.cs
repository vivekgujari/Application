using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public static class API
{
    public static int add(int a, int b)
    {
        return a + b;
    }

    public static int div(int a, int b)
    {
        if (b == 0)
            throw new Exception("Cannot divide by zero");
        return a / b;
    }
}
