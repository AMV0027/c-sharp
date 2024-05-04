using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of elements : ");
        int num = int.Parse(Console.ReadLine());
        
        int[] arr = new int[num];
        
        for(int i=0; i<num;i++){
            Console.Write("num {0} : ",i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        int min = arr[0], max = arr[0];
        
        for(int j=0; j<num;j++){
            if(arr[j] > max){
                max = arr[j];
            }
            if(arr[j] < min){
                min = arr[j];
            }
        }
        
        Console.WriteLine("Min element = {0}\nMax Element = {1}", min, max);
        

    }
}