using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter a,b,c : ");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        
        if (a > b){
            if (a>c){
                Console.WriteLine("a is the gratest");
            }else{
                Console.WriteLine("c is the greatest");
            }
        }else if(b > c){
            Console.WriteLine("b is greatest");
        }else{
            Console.WriteLine("c is greatest");
        }
    }
}