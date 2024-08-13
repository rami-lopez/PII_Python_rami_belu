Console.Write("2000 es bisiesto? :");
Console.WriteLine(Function.IsLeap(2000)); 

// Implementa en esta clase la función que corresponda

public static class Function
{
    public static bool IsLeap(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            return true;
        return false;
    }
}

