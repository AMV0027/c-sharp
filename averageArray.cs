using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double sum = 0, avg = 0;
        
        Console.Write("Enter number of elements : ");
        int num = int.Parse(Console.ReadLine());
        
        double[] number = new double[num];
        
        for(int i=0; i<num;i++){
            Console.Write("num {0} : ",i);
            number[i] = double.Parse(Console.ReadLine());
            sum += number[i];
        }
        
        avg = sum / number.Length;
        
        Console.WriteLine("Average = {0}", avg);

    }
}