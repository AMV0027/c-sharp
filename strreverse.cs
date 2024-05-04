using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str= "", revstr = "";
        
        int len = 0;
        
        Console.Write("Enter string : ");
        str = Console.ReadLine();
        
        len = str.Length - 1;
        Console.WriteLine(len);
        
        while(len >= 0){
            revstr = revstr + str[len];
            len--;
        }
        Console.WriteLine("Reversed string {0}", revstr);
        
    }
}