// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public delegate void addnum(int a, int b);
public delegate void subnum(int a, int b);
    
    
public class Math{
    
    public void sum(int a, int b){
        Console.WriteLine("{0} + {1} = {2}", a, b ,a+b);
    }
    public void subtract(int a, int b){
        Console.WriteLine("{0} - {1} = {2}",a,b,a-b);
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Math obj = new Math();
        
        addnum del_obj1 = new addnum(obj.sum);
        subnum del_obj2 = new subnum(obj.subtract);
        
        del_obj1(100,50);
        del_obj2(50,20);
    }
}