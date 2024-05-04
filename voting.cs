using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your age ; ");
        int age = int.Parse(Console.ReadLine());
        
        if (age > 18 || age == 18){
            Console.WriteLine("Eligible to vote .");
        }else{
            Console.WriteLine("Not Eligible to vote .");
        }
    }
}