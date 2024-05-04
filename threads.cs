using System;
using System.Threading;
using System.Threading.Tasks; 


public class TFunction{
    public void even(){
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            if(num%2 == 0){
                Console.WriteLine("{0} is even", num);
            }else{
                Console.WriteLine("{0} is not even", num);
            }
        }
        
        public void sum(){
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            
            int sum = 0;
            
            while(num != 0){
                int temp = num % 10 ;
                sum += temp;
                num = num / 10 ;
            }
            Console.WriteLine("sum of unit digits = {0}", sum);
        }
}

public class HelloWorld
{
    
    public static void Main(string[] args)
    {
        TFunction tf = new TFunction();
        Thread t1 = new Thread(new ThreadStart(tf.even));
        Thread t2 = new Thread(new ThreadStart(tf.sum));
        
        t1.Start();
        t2.Start();
        
    }
}