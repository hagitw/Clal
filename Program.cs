using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clal_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor actor = new Actor();
           
            if (!actor.Init())
            {
                Console.WriteLine("Error");
                Console.ReadLine();
                
            }
         
            Console.WriteLine("Enter number to start");
            string strInput = Console.ReadLine();

            if (int.TryParse(strInput, out int input))
            {
                actor.Startprocc(input);
                Console.WriteLine("Ended");
                Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("Enter number to start");
                Console.ReadLine();
            }
        }
    }
}
