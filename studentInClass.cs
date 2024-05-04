using System;

public class student{
    public int id;
    public string name, batch, dept;
    
    public void insert(int i, string n, string b, string d){
        id = i;
        name = n;
        batch = b;
        dept = d;
    }
    public void display(){
        Console.WriteLine("\nname:{0}\nid:{1}\nbatch:{2}\ndept:{3}\n",name, id, batch, dept);
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        student s1 = new student();
        student s2 = new student();
        
        s1.insert(5011, "arun", "2022-26", "IT");
        s2.insert(5003, "joe", "2023-2025", "IT");
        
        s1.display();
        s2.display();
        
    }
}