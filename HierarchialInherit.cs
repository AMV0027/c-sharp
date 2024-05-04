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

public class C : A{
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
        c.print3();
        
        B b = new B();
        b.print2();
        b.print1();
    }
}