using System;

public class animal{
    public virtual void makeSound(){
        Console.WriteLine("Animal makes sound 🫏");
    }
}

class dog : animal{
    public override void makeSound(){
        Console.WriteLine("bark!!!");
    }
}
class cat : animal{
    public override void makeSound(){
        Console.WriteLine("Meow !!!");
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        animal anim = new animal();
        anim.makeSound();
        
        dog d = new dog();
        d.makeSound();
        
        cat c = new cat();
        c.makeSound();
        
    }
}