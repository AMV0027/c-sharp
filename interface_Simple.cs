using System;

interface animal{
    void animalSound();
}

class lion : animal{
    public void animalSound(){
        Console.WriteLine("Roarrr!!!!");
    }
}
class dog : animal{
    public void animalSound(){
        Console.WriteLine("Barkkkkk!!!!");
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        lion l = new lion();
        l.animalSound();
        
        dog d = new dog();
        d.animalSound();
    }
}