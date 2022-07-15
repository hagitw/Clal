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
            int input;

            while (int.TryParse(strInput, out input) == false)
            {
                Console.WriteLine("Enter number to start");
                strInput = Console.ReadLine();
            }

            actor.StartFlow(input);

            Console.WriteLine("End");
            Console.ReadLine();

        }
    }
}
