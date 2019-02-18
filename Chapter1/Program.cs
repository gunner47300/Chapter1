using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {

        static void Main()
        {
            int j = 0;
           
            Console.WriteLine("Good day mr Łukasz Hetman!");
            Console.WriteLine("1 \n101 \n1001");
            Console.WriteLine((DateTime.Now));
            Console.WriteLine(Math.Sqrt(12345));
            for(int i=2; i<=102; i+=2)
            {
                if(j<101)
                {
                    Console.WriteLine(j + ". " + i);
                    j++;
                }
               
                if(j<100)
                {
                    Console.WriteLine(j + ". " + -(i + 1));
                    j++;
                }
            }
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Za 10 lat będziesz mieć {0} lat", age);
        }
    }
}
