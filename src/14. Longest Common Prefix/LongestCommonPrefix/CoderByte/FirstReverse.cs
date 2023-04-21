using System;
using System.Text;

class MainClass
{

    public static string FirstReverse(string str)
    {
        if (str == null) return str;

        StringBuilder stringOUTPUT = new StringBuilder();
        int length = str.Length - 1;
        for (int i = length; i < str.Length; i--)
        {
            if (i < 0) break;
            stringOUTPUT.Append(str[i]);
        }


        return stringOUTPUT.ToString();

    }

    static void Main()
    {

        // keep this function call here
        Console.WriteLine(FirstReverse("Hello World and Coders"));

    }

}