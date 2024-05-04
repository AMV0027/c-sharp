using System;

public class building{
    public void area(int a){
        Console.WriteLine("Area of square = {0}", a*a);
    }
    public void area(int a, int b){
        Console.WriteLine("Area of rectangle = {0}", a*b);
    }
}


public class HelloWorld
{
    public static void Main(string[] args)
    {
        building obj = new building();
        
        obj.area(5);
        obj.area(21,4);
        
    }
}