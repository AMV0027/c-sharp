// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class A{
    public void print1(){
        Console.WriteLine("Im main class");
    }
    
}

public class B : A{
    public void print2(){
        Console.WriteLine("I inherit main class");
    }
    
}

public class C : B{
    public void print3(){
        Console.WriteLine("I inherit main class");
    }
    
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        C c = new C();
        c.print1();
        c.print2();
        c.print3();
    }
}