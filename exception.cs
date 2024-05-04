using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Enter a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Division = {0}", a/b);
        }catch{
            Console.WriteLine("Enter valid numbers !");
        }finally{
            Console.WriteLine("Thank you !");
        }
    }
}