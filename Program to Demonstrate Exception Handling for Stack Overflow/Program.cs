using System;
class Program////This C# program is used to demonstrate exception handling for stack overflow. Typically the StackOverflowException is triggered by a recursive method that creates a deep call stack. Using try and catch, an error message is displayed when the error occurs.
/////////////////Runtime Test Cases///
{
    static void excep(int value)
    {
        Console.WriteLine(value);
        excep(++value);
    }

    static void Main()
    {
        try
        {
            excep(0);
        }
        catch (StackOverflowException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
////Output: Program terminated due to StackOverflow Exception.