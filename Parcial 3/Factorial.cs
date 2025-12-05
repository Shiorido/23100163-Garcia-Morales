using System;

public class Factorial
{
    public static int Factorial(int x)
    {

        if (x == 1)
        {
            return x; 
        }
        
        return x * Factorial(x - 1);
    }
}
