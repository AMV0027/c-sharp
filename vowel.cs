using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a character : ");
        
        char c = char.Parse(Console.ReadLine().ToUpper());
        
        switch(c){
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
            Console.WriteLine("the Character is vowel.");
            break;
            default:
            Console.WriteLine("Not a vowel");
            break;
        }
    }
}