Console.WriteLine($"El factorial de 5 es: {Functions.FactorialFor(5)}");
Console.WriteLine($"El factorial de 5 es: {Functions.FactorialWhile(5)}");

// Implementa en esta clase la función que corresponda

public static class Functions
{
    public static int FactorialFor(int number)
    {
        int i = 1;
        for (int num2=1; num2 <= number; num2++)
        {
            i *= num2;
        }
        return i;
    }

    public static int FactorialWhile(int number)
    {
        int i = 1;
        int num2 = 1;
        while (num2 <= number)
        {
            i *= num2;
            num2 += 1;
        }
        return i;
    }
}

