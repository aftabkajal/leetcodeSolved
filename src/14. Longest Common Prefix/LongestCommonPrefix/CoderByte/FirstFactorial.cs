using System;

class FirstFactorialMainClass
{

    public static int FirstFactorial(int num)
    {

        var factorial = 1;
        for (var i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;

    }

    static void Main()
    {

        // keep this function call here
        Console.WriteLine(FirstFactorial(Console.ReadLine()));

    }

}