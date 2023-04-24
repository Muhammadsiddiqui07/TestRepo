using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  //Question :01
              Console.WriteLine("Enter a table number");
              int tn = Convert.ToInt32(Console.ReadLine());

              for(int i = 1; i <= 24; i++)
              {
                  Console.WriteLine(tn + "x" + i + "=" + tn * i);
              }*/


            
            //Question :02
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int n = 1; n < (num + n); n++)
            {
                if(n % 2 != 0 )
                {
                    Console.WriteLine(n);
                }
                
            } 

            /*
            
            //Question :03
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=num; i++)
            {
                if(i % 5 != 0 && i % 9 != 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*
            //Question :04
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);*/


            //Question :05

      


            Console.ReadLine();
        }
    }
}
