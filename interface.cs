// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

interface addi {int plus(int a, int b);}
interface subt {int minus(int a1, int b1);}
interface divi {int slash(int a2, int b2);}
interface mult {int cross(int a3, int b3);}

public class operations : addi, subt, divi, mult
{
    public int plus(int a, int b){
        return a+b;
    }
    public int minus(int a1, int b1){
        return a1-b1;
    }
    public int mult(int a2, int b2){
        return a2*b2;
    }
    public int divi(int a3, int b3){
        return a3/b3;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        operations obj = new operations();
        
        Console.WriteLine("Addition : "+obj.plus(40,51));
        Console.WriteLine("Substraction : "+obj.minus(85,12));
        Console.WriteLine("Multiplication : "+ obj.cross(15,15));
        Console.WriteLine("Division : "+ obj.slash(15,3));
    }
}