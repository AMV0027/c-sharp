using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter string : ");
        
        string str = Console.ReadLine();

        Console.WriteLine("String size : {0}", str.Length);
    }
}