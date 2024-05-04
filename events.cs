// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public delegate int operationDelegate(int a, int b);

public class calculator{
    public int add(int a, int b){
        return a+b;
    }
    public int sub(int a, int b){
        return a-b;
    }
    public int mul(int a, int b){
        return a*b;
    }
    public int div(int a, int b){
        return a/b;
    }
    
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        calculator obj = new calculator();
        
        operationDelegate Del_add = new operationDelegate(obj.add);
        operationDelegate Del_sub = new operationDelegate(obj.sub);
        operationDelegate Del_mul = new operationDelegate(obj.mul);
        operationDelegate Del_div = new operationDelegate(obj.div);
        
        Console.WriteLine("Addition = {0}", Del_add(5,6));
        Console.WriteLine("Subtraction = {0}", Del_sub(51,23));
        Console.WriteLine("Division = {0}", Del_div(42,12));
        Console.WriteLine("Multiplication = {0}", Del_mul(5,5));
        
    }
}