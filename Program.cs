using System;
using System.Collections.Generic;
namespace FunctionsMethods
{
    class Program
    {
        
        static void task1()
        {
            Console.WriteLine("Welcome Friends! ");
            Console.WriteLine("Have a nice day! ");
        }
         static void task8(int len)  
{  
                int a = 0, b = 1, c = 0;  
                Console.Write("{0} {1}", a,b);  
                for (int i = 2; i < len; i++)  
                {  
                    c= a + b;  
                Console.Write(" {0}", c);  
                a= b;  
                b= c;  
                }
               
} 
            public static int task10(int a) 
        { 
            string number = Convert.ToString(a);
            int added = 0;  
            for (int i = 0; i < number.Length; i++){
                added += int.Parse(number.Substring(i,1));
            }
            return added;
        }
        static void Main(string[] args)
        {
        //Uncomment a task to run it. Comment it when you wanna try another
        
        //TASK 1
         //  task1();
        //TASK 2
        /*    string name;
            Console.WriteLine("Please input a name ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome friend " + name + "!");
            Console.WriteLine("Have a nice day!"); */
        
        //TASK 3
           
         /* Console.WriteLine("Enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("the sum of two numbers is ");
            int total;
            total = number + number2;
            Console.Write(total); */

        //TASK 4
        /* Console.WriteLine("Please input a string: ");
        string input;    
        input = Console.ReadLine();
      
        int spaces1 = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
            {
                spaces1++;
            }
        }
          int spaces2 = 0;
            
        
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].ToString() == " ")
            {
                spaces2++;
            }
        }
           Console.WriteLine(input + " contains " + spaces1 + " spaces"); */

           //TASK 5

            /* int[] t5array = new int[100];
            int i, n , sum = 0;
   
	        n = Convert.ToInt32(5); 
            Console.WriteLine("input 5 elements in the array");
           
            for(i=0; i <n;i++)
            {
                Console.Write("element - {0} : ",i);
		        t5array[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(i=0; i<n; i++)
            {
             sum += t5array[i];
            }
           Console.Write("The sum of elements of the array is " + sum);  */

           //TASK 6
           
            /*    Console.WriteLine("Enter a Number: ");
                int a= int.Parse(Console.ReadLine());
                Console.WriteLine("And another Number: ");
                int b= int.Parse(Console.ReadLine());
                Console.WriteLine("Now the first number is "+ b +" And the second is " + a ); */
           //TASK 7
             /*   Console.Write("Enter first number: ");
                double a =double.Parse(Console.ReadLine());
                Console.Write("Enter Exponent: ");
                double b =double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Pow(a, b)); 
                }*/
            //TASK 8
               /* Console.WriteLine("How many lines of fibonacci would you like to print");
                int a = int.Parse(Console.ReadLine());
                task8(a);
                } */
            //TASK 9
            
           /* int n, i, m=0, prime=0;    
            Console.Write("Input a number ");    
             n = int.Parse(Console.ReadLine());  
                m=n/2;    
            for(i = 2; i <= m; i++)    
            {    
            if(n % i == 0)    
            {    
             Console.Write(n + " is not prime");    
             prime=1;    
             break;    
            }    
          }    
          if (prime==0)    
           Console.Write(n + " is prime");       */
           //TASK 10
            /*
            Console.Write("Enter a number: ");
            int numberEntered = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the digits of the number "+ numberEntered + " is: " + task10(numberEntered));    
            */
   
            
        }
    }
}   


